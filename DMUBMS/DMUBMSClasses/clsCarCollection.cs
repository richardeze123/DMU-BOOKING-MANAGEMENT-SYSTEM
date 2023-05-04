using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMUBMSClasses
{
    public class clsCarCollection
    {
        //private data member for the list
        List<clsCar> mCarList = new List<clsCar>();
        //private data member thisCar
        clsCar mThisCar = new clsCar();

        //constructor for the class
        public clsCarCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCar_SelectAll");
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
            mCarList = new List<clsCar>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCar AnCar = new clsCar();
                //read in the fields from the current record

                AnCar.Price = Convert.ToString(DB.DataTable.Rows[Index]["Price"]);
                AnCar.RegNo = Convert.ToString(DB.DataTable.Rows[Index]["RegNo"]);
                AnCar.Model = Convert.ToString(DB.DataTable.Rows[Index]["Model"]);
                AnCar.Brand = Convert.ToString(DB.DataTable.Rows[Index]["Brand"]);
                AnCar.Available = Convert.ToString(DB.DataTable.Rows[Index]["Available"]);
                
                //add the record to the private data mamber
                mCarList.Add(AnCar);
                //point at the next record
                Index++;
            }

        }

        public List<clsCar> CarList
        {
            get
            {
                //return the private data
                return mCarList;
            }
            set
            {
                //set the private data
                mCarList = value;
            }




        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mCarList.Count;
            }
            set
            {
                //we shall worry about this later
            }


        }
        //public property for ThisHotel
        public clsCar ThisCar
        {
            get
            {
                //return the private data
                return mThisCar;
            }
            set
            {
                //set the private data
                mThisCar = value;
            }
        }
        public int Add()
        {
            //adds a new record to the database based on the values of thisCar
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@RegNo", mThisCar.RegNo);
            DB.AddParameter("@Model", mThisCar.Model);
            DB.AddParameter("@Price", mThisCar.Price);
            DB.AddParameter("@Avaialabe", mThisCar.Available);
            DB.AddParameter("@Brand", mThisCar.Brand);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCar_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by this
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@RegNo", mThisCar.RegNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCar_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisCar
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@RegNo", mThisCar.RegNo);
            DB.AddParameter("@Model", mThisCar.Model);
            DB.AddParameter("@Price", mThisCar.Price);
            DB.AddParameter("@Brand", mThisCar.Brand);
            DB.AddParameter("@Available", mThisCar.Available);
            //execute the stored procedure
            DB.Execute("sproc_tblCar_Update");
        }

        public void ReportByRegNo(string RegNo)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the HotelName parameter to the database
            DB.AddParameter("@RegNo", RegNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCar_FilterByRegNo");
            //populate the array list with the data table
            PopulateArray(DB);
        }






    }
}




