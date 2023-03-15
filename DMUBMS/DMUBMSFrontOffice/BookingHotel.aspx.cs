using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMUBMSClasses;

namespace DMUBMSFrontOffice
{
    public partial class BookingHotel : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 HotelNo;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the Hotel to be processed
            HotelNo = Convert.ToInt32(Session["HotelNo"]);
            if (IsPostBack == false)
            {
                //if this is not a new record
                if (HotelNo != -1)
                {
                    //display the current data for the record
                    DisplayHotel();
                }
            }
        }

        void DisplayHotel()
        {
            //create an instance of the Hotel book
            clsHotelCollection HotelBook = new clsHotelCollection();
            //find the record to Book
            HotelBook.ThisHotel.Find(HotelNo);
            //display the data for this record
            txtStarRating.Text = HotelBook.ThisHotel.StarRating + "⭐"; ;
            txtPhoneNumber.Text = HotelBook.ThisHotel.PhoneNumber;
            txtHotelAddress.Text = HotelBook.ThisHotel.HotelAddress;
            txtHotelName.Text = HotelBook.ThisHotel.HotelName;
            txtHotelName.ReadOnly = true;
            txtHotelAddress.ReadOnly = true;
            txtPhoneNumber.ReadOnly = true;
            txtStarRating.ReadOnly = true;
        }

        protected void btnPAYMENT_Click1(object sender, EventArgs e)
        {

        }

        protected void btnPAYMENT_Click(object sender, EventArgs e)
        {
            //navigate to the payment page
            Response.Redirect("Payment.aspx");
        }

        protected void txtHotelName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtHotelAddress_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtStarRating_TextChanged(object sender, EventArgs e)
        {

        }
    }
}