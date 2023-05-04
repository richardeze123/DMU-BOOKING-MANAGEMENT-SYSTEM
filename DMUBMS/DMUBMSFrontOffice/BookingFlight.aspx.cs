using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMUBMSClasses;

namespace DMUBMSFrontOffice
{
    public partial class BookingFlight : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 FlightNo;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the Hotel to be processed
            FlightNo = Convert.ToInt32(Session["FlightNo"]);
            if (IsPostBack == false)
            {
                //if this is not a new record
                if (FlightNo != -1)
                {
                    //display the current data for the record
                    DisplayFlight();
                }
            }
        }

        void DisplayFlight()
        {
            //create an instance of the Hotel book
            clsFlightCollection FlightBook = new clsFlightCollection();
            //find the record to Book
            FlightBook.ThisFlight.Find(FlightNo);
            //display the data for this record
            txtFlightGroup.Text = FlightBook.ThisFlight.FlightGroup + "⭐"; ;
            txtFlightCode.Text = FlightBook.ThisFlight.FlightCode;
            txtFlightCompany.Text = FlightBook.ThisFlight.FlightCompany;
            txtFlightName.Text = FlightBook.ThisFlight.FlightName;
            txtFlightName.ReadOnly = true;
            txtFlightCompany.ReadOnly = true;
            txtFlightCode.ReadOnly = true;
            txtFlightGroup.ReadOnly = true;
        }

        protected void btnPAYMENT_Click1(object sender, EventArgs e)
        {

        }

        protected void btnPAYMENT_Click(object sender, EventArgs e)
        {
            //navigate to the payment page
            Response.Redirect("Payment.aspx");
        }

        protected void txtFlightName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtFlightCompany_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtFlightCode_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtFlightGroup_TextChanged(object sender, EventArgs e)
        {

        }
    }
}