using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMUBMSClasses
{
    public class clsFlight
    {
        //private data member for the HotelNo property
        private Int32 mFlightNo;
        //private data member for StarRating
        private string mFlightGroup;
        //private data member for PhoneNumber
        private string mFlightCode;
        //private data member for HotelAddress
        private string mFlightCompany;
        //private data member for HotelName
        private string mFlightName;
        //private date added data member
        private DateTime mDateAdded;
        //private data member for active
        private Boolean mActive;

        //public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }

        //public property for date added
        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the private data
                mDateAdded = value;
            }
        }

        //public property for the Hotel number
        public int FlightNo
        {
            get
            {
                //return the private data
                return mFlightNo;
            }
            set
            {
                //set the value of the private data member
                mFlightNo = value;
            }
        }


        //public property for StarRating
        public string FlightGroup
        {
            get
            {
                //return private data
                return mFlightGroup;
            }
            set
            {
                //set the private data
                mFlightGroup = value;
            }
        }

        //public property for HotelName
        public string FlightName
        {
            get
            {
                //return the private data
                return mFlightName;
            }
            set
            {
                //set the private data
                mFlightName = value;
            }
        }

        //public data member for PhoneNumber
        public string FlightCode
        {
            get
            {
                //return the private data
                return mFlightCode;
            }
            set
            {
                //set the private data
                mFlightCode = value;
            }
        }

        //public data member for HotelAddress
        public string FlightCompany
        {
            get
            {
                //return the private data
                return mFlightCompany;
            }
            set
            {
                //set the private data
                mFlightCompany = value;
            }
        }


        public bool Find(int FlightNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the HotelNo to search for
            DB.AddParameter("@FlightNo", FlightNo);
            //execute the stored procedure
            DB.Execute("sproc_tblFlight_FilterByFlightNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mFlightNo = Convert.ToInt32(DB.DataTable.Rows[0]["FlightNo"]);
                mFlightGroup = Convert.ToString(DB.DataTable.Rows[0]["FlightGroup"]);
                mFlightCode = Convert.ToString(DB.DataTable.Rows[0]["FlightCode"]);
                mFlightCompany = Convert.ToString(DB.DataTable.Rows[0]["FlightCompany"]);
                mFlightName = Convert.ToString(DB.DataTable.Rows[0]["FlightName"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string flightGroup, string flightCode, string flightCompany, string flightName, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the starRating is blank
            if (flightGroup.Length == 0)
            {
                //record the error
                Error = Error + "The Star Rating may not be blank : ";
            }
            //if the starRating is greater than 1 character
            if (flightGroup.Length > 1)
            {
                //record the error
                Error = Error + "The Star Rating must be less than 1 character : ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //is the hotelName blank
            if (flightName.Length == 0)
            {
                //record the error
                Error = Error + "The Hotel Name may not be blank : ";
            }
            //if the hotelName is too long
            if (flightName.Length > 50)
            {
                //record the error
                Error = Error + "The Hotel Name must be less than 50 characters : ";
            }
            //is the phoneNumber blank
            if (flightCode.Length == 0)
            {
                //record the error
                Error = Error + "The Phone Number may not be blank : ";
            }
            //if the phoneNumber is too long
            if (flightCode.Length > 20)
            {
                //record the error
                Error = Error + "The Phone Number must be less than 20 characters : ";
            }
            //is the hotelAddress blank
            if (flightCompany.Length == 0)
            {
                //record the error
                Error = Error + "The Hotel Address may not be blank : ";
            }
            //if the hotelAddress is too long
            if (flightCompany.Length > 50)
            {
                //record the error
                Error = Error + "The Hotel Address must be less than 50 characters : ";
            }
            //return any error messages
            return Error;
        }
    }
}
