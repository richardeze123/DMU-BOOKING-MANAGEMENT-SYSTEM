using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMUBMSClasses
{
    public class clsFlightCollection
    {
        //private data member for the list
        List<clsFlight> mFlightList = new List<clsFlight>();
        //private data member thisHotel
        clsFlight mThisFlight = new clsFlight();

        //constructor for the class
        public clsFlightCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblFlight_SelectAll");
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
            mFlightList = new List<clsFlight>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsFlight AnFlight = new clsFlight();
                //read in the fields from the current record
                AnFlight.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnFlight.FlightNo = Convert.ToInt32(DB.DataTable.Rows[Index]["FlightNo"]);
                AnFlight.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnFlight.FlightGroup = Convert.ToString(DB.DataTable.Rows[Index]["FlightGroup"]);
                AnFlight.FlightName = Convert.ToString(DB.DataTable.Rows[Index]["FlightName"]);
                AnFlight.FlightCode = Convert.ToString(DB.DataTable.Rows[Index]["FlightCode"]);
                AnFlight.FlightCompany = Convert.ToString(DB.DataTable.Rows[Index]["FlightCompany"]);
                //add the record to the private data mamber
                mFlightList.Add(AnFlight);
                //point at the next record
                Index++;
            }

        }

        //public property for the Hotel list
        public List<clsFlight> FlightList
        {
            get
            {
                //return the private data
                return mFlightList;
            }
            set
            {
                //set the private data
                mFlightList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mFlightList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public property for ThisHotel
        public clsFlight ThisFlight
        {
            get
            {
                //return the private data
                return mThisFlight;
            }
            set
            {
                //set the private data
                mThisFlight = value;
            }
        }



        public int Add()
        {
            //adds a new record to the database based on the values of thisHotel
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FlightGroup", mThisFlight.FlightGroup);
            DB.AddParameter("@FlightCode", mThisFlight.FlightCode);
            DB.AddParameter("@FlightCompany", mThisFlight.FlightCompany);
            DB.AddParameter("@FlightName", mThisFlight.FlightName);
            DB.AddParameter("@DateAdded", mThisFlight.DateAdded);
            DB.AddParameter("@Active", mThisFlight.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblFlight_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisHotel
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FlightNo", mThisFlight.FlightNo);
            //execute the stored procedure
            DB.Execute("sproc_tblFlight_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisHotel
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FlightNo", mThisFlight.FlightNo);
            DB.AddParameter("@FlightGroup", mThisFlight.FlightGroup);
            DB.AddParameter("@FlightCode", mThisFlight.FlightCode);
            DB.AddParameter("@FlightCompany", mThisFlight.FlightCompany);
            DB.AddParameter("@FlightName", mThisFlight.FlightName);
            DB.AddParameter("@DateAdded", mThisFlight.DateAdded);
            DB.AddParameter("@Active", mThisFlight.Active);
            //execute the stored procedure
            DB.Execute("sproc_tblFlight_Update");
        }

        public void ReportByFlightName(string FlightName)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the HotelName parameter to the database
            DB.AddParameter("@FlightName", FlightName);
            //execute the stored procedure
            DB.Execute("sproc_tblFlight_FilterByFlightName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}
