using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMUBMSClasses;

namespace DMUBMSFrontOffice
{
    public partial class DeleteFlight : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 FlightNo;

        //event handler for the load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the Hotel to be deleted from the session object
            FlightNo = Convert.ToInt32(Session["FlightNo"]);
        }

        //event handler for the yes button
        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteFlightt();
            //redirect back to the main page
            Response.Redirect("DefaultFlight.aspx");
        }

        //event handler for the no button
        protected void btnNo_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("DefaultFlight.aspx");
        }

        void DeleteFlightt()
        {
            //function to delete the selected record

            //create a new instance of the Hotel book
            clsFlightCollection FlightBook = new clsFlightCollection();
            //find the record to delete
            FlightBook.ThisFlight.Find(FlightNo);
            //delete the record
            FlightBook.Delete();
        }
    }
}