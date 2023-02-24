using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMUBMSClasses
{
    class clsHotel
    {
        //private data member for the HotelNo property
        private Int32 mHotelNo;
        //private data member for StarRating
        private string mStarRating;
        //private data member for PhoneNumber
        private string mPhoneNumber;
        //private data member for HotelAddress
        private string mHotelAddress;
        //private data member for HotelName
        private string mHotelName;
        //private data member for county no
        private Int32 mRoomsAvailable;
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
        public int HotelNo
        {
            get
            {
                //return the private data
                return mHotelNo;
            }
            set
            {
                //set the value of the private data member
                mHotelNo = value;
            }
        }

        //public property for Room No
        public int RoomsAvailable
        {
            get
            {
                //return the private data
                return mRoomsAvailable;
            }
            set
            {
                //set the private data
                mRoomsAvailable = value;
            }
        }

        //public property for StarRating
        public string StarRating
        {
            get
            {
                //return private data
                return mStarRating;
            }
            set
            {
                //set the private data
                mStarRating = value;
            }
        }

        //public property for HotelName
        public string HotelName
        {
            get
            {
                //return the private data
                return mHotelName;
            }
            set
            {
                //set the private data
                mHotelName = value;
            }
        }

        //public data member for PhoneNumber
        public string PhoneNumber
        {
            get
            {
                //return the private data
                return mPhoneNumber;
            }
            set
            {
                //set the private data
                mPhoneNumber = value;
            }
        }

        //public data member for HotelAddress
        public string HotelAddress
        {
            get
            {
                //return the private data
                return mHotelAddress;
            }
            set
            {
                //set the private data
                mHotelAddress = value;
            }
        }


        public bool Find(int HotelNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Hotelno to search for
            DB.AddParameter("@HotelNo", HotelNo);
            //execute the stored procedure
            DB.Execute("sproc_tblHotel_FilterByHotelNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mHotelNo = Convert.ToInt32(DB.DataTable.Rows[0]["HotelNo"]);
                mStarRating = Convert.ToString(DB.DataTable.Rows[0]["StarRating"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mHotelAddress = Convert.ToString(DB.DataTable.Rows[0]["HotelAddress"]);
                mHotelName = Convert.ToString(DB.DataTable.Rows[0]["HotelName"]);
                mRoomsAvailable = Convert.ToInt32(DB.DataTable.Rows[0]["RoomsAvailable"]);
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

        public string Valid(string starRating, string phoneNumber, string hotelAddress, string hotelName, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the starRating is blank
            if (starRating.Length == 0)
            {
                //record the error
                Error = Error + "The Star Rating may not be blank : ";
            }
            //if the starRating is greater than 6 characters
            if (starRating.Length > 1)
            {
                //record the error
                Error = Error + "The Star Rating must be less than 1 characters : ";
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
            if (hotelName.Length == 0)
            {
                //record the error
                Error = Error + "The Hotel Name may not be blank : ";
            }
            //if the post code is too long
            if (hotelName.Length > 50)
            {
                //record the error
                Error = Error + "The Hotel Name must be less than 50 characters : ";
            }
            //is the phoneNumber blank
            if (phoneNumber.Length == 0)
            {
                //record the error
                Error = Error + "The Phone Number may not be blank : ";
            }
            //if the phoneNumber is too long
            if (phoneNumber.Length > 20)
            {
                //record the error
                Error = Error + "The Phone Number must be less than 20 characters : ";
            }
            //is the hotelAddress blank
            if (hotelAddress.Length == 0)
            {
                //record the error
                Error = Error + "The Hotel Address may not be blank : ";
            }
            //if the hotelAddress is too long
            if (hotelAddress.Length > 50)
            {
                //record the error
                Error = Error + "The Hotel Address must be less than 50 characters : ";
            }
            //return any error messages
            return Error;
        }
    }
}