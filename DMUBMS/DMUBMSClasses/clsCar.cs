using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMUBMSClasses
{

    public class clsCar
    {
        //private data member for the HotelNo property
        private string mRegNo;
        //private data member for RegNo
        private string mBrand;
        //private data member for Brand
        private string mModel;
        //private data member for Model
        private string mPrice;
        //private data member for HotelName
        private string mAvailable;
        //private data member for Avaiable

        //public property for StarRating
        public string RegNo
        {
            get
            {
                //return private data
                return mRegNo;
            }
            set
            {
                //set the private data
                mRegNo = value;
            }
        }

        public string Brand
        {

            get
            {
                //return private data
                return mBrand;
            }
            set
            {
                //set the private data
                mBrand = value;
            }
        }

        public string Model
        {

            get
            {
                //return private data
                return mModel;
            }
            set
            {
                //set the private data
                mModel = value;
            }
        }
        public string Price
        {

            get
            {
                //return private data
                return mPrice;
            }
            set
            {
                //set the private data
                mPrice = value;
            }
        }
        public string Available
        {

            get
            {
                //return private data
                return mAvailable;
            }
            set
            {
                //set the private data
                mAvailable = value;
            }
        }
        public bool Find(String RegNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the RegNo to search for
            DB.AddParameter("@RegNo", RegNo);
            //execute the stored procedure
            DB.Execute("sproc_tblHotel_FilterByRegNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members

                mRegNo = Convert.ToString(DB.DataTable.Rows[0]["RegNo"]);
                mAvailable = Convert.ToString(DB.DataTable.Rows[0]["Avaiable"]);
                mPrice = Convert.ToString(DB.DataTable.Rows[0]["Price"]);
                mBrand = Convert.ToString(DB.DataTable.Rows[0]["Brand"]);
                mModel = Convert.ToString(DB.DataTable.Rows[0]["Model"]);

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

        public string Valid(string text1, string text2, string text3, string text4)
        {
            throw new NotImplementedException();
        }

        public string Valid(string RegNo, string Model, string Price, string Brand, string Available)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            //if the starRating is blank
            if (RegNo.Length == 0)
            {
                //record the error
                Error = Error + "The RegNo may not be blank : ";
            }
            //if the RegNo is greater than 1 character
            if (RegNo.Length > 1)
            {
                //record the error
                Error = Error + "The RegNo must be less than 1 character : ";
            }

            //is the price blank
            if (Price.Length == 0)
            {
                //record the error
                Error = Error + "The Price may not be blank : ";
            }
            //if the price is too long
            if (Price.Length > 50)
            {
                //record the error
                Error = Error + "The Price must be less than 50 characters : ";
            }
            //is the model blank
            if (Model.Length == 0)
            {
                //record the error
                Error = Error + "The Model may not be blank : ";
            }
            //if the model is too long
            if (Model.Length > 20)
            {
                //record the error
                Error = Error + "The Model must be less than 20 characters : ";
            }
            //is the Available  blank
            if (Available.Length == 0)
            {
                //record the error
                Error = Error + "The Avaiable may not be blank : ";
            }
            //if the Available is too long
            if (Available.Length > 50)
            {
                //record the error
                Error = Error + "The Avaiable must be less than 50 characters : ";
            }
            //return any error messages
            return Error;
        }

        public string Valid(string model, string brand, string price)
        {
            throw new NotImplementedException();
        }
    }
}







