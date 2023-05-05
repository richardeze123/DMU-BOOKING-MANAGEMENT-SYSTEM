using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMUBMSFrontOffice
{
    public partial class indexFlight : System.Web.UI.Page
    {
        //this function handles the load event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayFlights();
            }
        }

        void DisplayFlights()
        {
            //create an instance of the RoomsAvailable Collection
            DMUBMSClasses.clsFlightCollection Flights = new DMUBMSClasses.clsFlightCollection();
            //set the data source to the list of RoomsAvailables in the collection
            lstFlights.DataSource = Flights.FlightList;
            //set the name of the primary key
            lstFlights.DataValueField = "FlightNo";
            //set the data field to display
            lstFlights.DataTextField = "FlightName";
            //bind the data to the list
            lstFlights.DataBind();
        }

        protected void lstFlights_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnBookNow_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 FlightNo;
            //if a record has been selected from the list
            if (lstFlights.SelectedIndex != -1)
            {
                //get the primary key value of the record to edit
                FlightNo = Convert.ToInt32(lstFlights.SelectedValue);
                //store the data in the session object
                Session["FlightNo"] = FlightNo;
                //redirect to the Booking page page
                Response.Redirect("BookingFlight.aspx");
            }
            else//if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a Hotel to Book from the list.";
            }
        }
    }
}