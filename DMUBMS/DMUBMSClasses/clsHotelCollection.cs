using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMUBMSClasses
{
    public class clsHotelCollection
    {
        //private data member for the list
        List<clsHotel> mHotelList = new List<clsHotel>();
        //private data member thisHotel
        clsHotel mThisHotel = new clsHotel();

        //constructor for the class
        public clsHotelCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblHotel_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }


        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mHotelList = new List<clsHotel>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsHotel AnHotel = new clsHotel();
                //read in the fields from the current record
                AnHotel.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnHotel.HotelNo = Convert.ToInt32(DB.DataTable.Rows[Index]["HotelNo"]);
                AnHotel.RoomsAvailableNo = Convert.ToInt32(DB.DataTable.Rows[Index]["RoomsAvailableNo"]);
                AnHotel.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnHotel.StarRating = Convert.ToString(DB.DataTable.Rows[Index]["StarRating"]);
                AnHotel.HotelName = Convert.ToString(DB.DataTable.Rows[Index]["HotelName"]);
                AnHotel.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                AnHotel.HotelAddress = Convert.ToString(DB.DataTable.Rows[Index]["HotelAddress"]);
                //add the record to the private data mamber
                mHotelList.Add(AnHotel);
                //point at the next record
                Index++;
            }

        }

        //public property for the Hotel list
        public List<clsHotel> HotelList
        {
            get
            {
                //return the private data
                return mHotelList;
            }
            set
            {
                //set the private data
                mHotelList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mHotelList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public property for ThisHotel
        public clsHotel ThisHotel
        {
            get
            {
                //return the private data
                return mThisHotel;
            }
            set
            {
                //set the private data
                mThisHotel = value;
            }
        }



        public int Add()
        {
            //adds a new record to the database based on the values of thisHotel
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StarRating", mThisHotel.StarRating);
            DB.AddParameter("@PhoneNumber", mThisHotel.PhoneNumber);
            DB.AddParameter("@HotelAddress", mThisHotel.HotelAddress);
            DB.AddParameter("@HotelName", mThisHotel.HotelName);
            DB.AddParameter("@RoomsAvailableNo", mThisHotel.RoomsAvailableNo);
            DB.AddParameter("@DateAdded", mThisHotel.DateAdded);
            DB.AddParameter("@Active", mThisHotel.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblHotel_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisHotel
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@HotelNo", mThisHotel.HotelNo);
            //execute the stored procedure
            DB.Execute("sproc_tblHotel_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisHotel
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@HotelNo", mThisHotel.HotelNo);
            DB.AddParameter("@StarRating", mThisHotel.StarRating);
            DB.AddParameter("@PhoneNumber", mThisHotel.PhoneNumber);
            DB.AddParameter("@HotelAddress", mThisHotel.HotelAddress);
            DB.AddParameter("@HotelName", mThisHotel.HotelName);
            DB.AddParameter("@RoomsAvailableNo", mThisHotel.RoomsAvailableNo);
            DB.AddParameter("@DateAdded", mThisHotel.DateAdded);
            DB.AddParameter("@Active", mThisHotel.Active);
            //execute the stored procedure
            DB.Execute("sproc_tblHotel_Update");
        }

        public void ReportByHotelName(string HotelName)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the HotelName parameter to the database
            DB.AddParameter("@HotelName", HotelName);
            //execute the stored procedure
            DB.Execute("sproc_tblHotel_FilterByHotelName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}