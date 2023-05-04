using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMUBMSClasses;

namespace DMUBMSFrontOffice
{
    public partial class AnFlight : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 FlightNo;


        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {

            FlightNo = Convert.ToInt32(Session["FlightNo"]);
            if (IsPostBack == false)
            {
                if (FlightNo != -1)
                {
                    //display the current data for the record
                    DisplayFlight();
                }
            }
        }


        //this is the event handler for the cancel button
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect to the main page
            Response.Redirect("DefaultFlight.aspx");
        }

        //event handler for the ok button
        protected void btnOk_Click(object sender, EventArgs e)
        {
            if (FlightNo == -1)
            {
                //add the new record
                Add();
            }
            else
            {
                //update the record
                Update();
            }
        }

        //function for adding new records
        void Add()
        {
            //create an instance of the Hotel book
            clsFlightCollection FlightBook = new clsFlightCollection();
            //validate the data on the web form
            String Error = FlightBook.ThisFlight.Valid(txtFlightGroup.Text, txtFlightCode.Text, txtFlightCompany.Text, txtFlightName.Text, txtDateAdded.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                FlightBook.ThisFlight.FlightGroup = txtFlightGroup.Text;
                FlightBook.ThisFlight.FlightCode = txtFlightCode.Text;
                FlightBook.ThisFlight.FlightCompany = txtFlightCompany.Text;
                FlightBook.ThisFlight.FlightName = txtFlightName.Text;
                FlightBook.ThisFlight.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
                FlightBook.ThisFlight.Active = chkActive.Checked;
                //add the record
                FlightBook.Add();
                //all done so redirect back to the main page
                Response.Redirect("DefaultFlight.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        //function for updateing records
        void Update()
        {
            //create an instance of the Hotel book
            DMUBMSClasses.clsFlightCollection FlightBook = new DMUBMSClasses.clsFlightCollection();
            //validate the data on the web form
            String Error = FlightBook.ThisFlight.Valid(txtFlightGroup.Text, txtFlightCode.Text, txtFlightCompany.Text, txtFlightName.Text, txtDateAdded.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //find the record to update
                FlightBook.ThisFlight.Find(FlightNo);
                //get the data entered by the user
                FlightBook.ThisFlight.FlightGroup = txtFlightGroup.Text;
                FlightBook.ThisFlight.FlightCode = txtFlightCode.Text;
                FlightBook.ThisFlight.FlightCompany = txtFlightCompany.Text;
                FlightBook.ThisFlight.FlightName = txtFlightName.Text;
                FlightBook.ThisFlight.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
                FlightBook.ThisFlight.Active = chkActive.Checked;
                //update the record
                FlightBook.Update();
                //all done so redirect back to the main page
                Response.Redirect("DefaultFlight.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        void DisplayFlight()
        {
            //create an instance of the Hotel book
            clsFlightCollection FlightBook = new clsFlightCollection();
            //find the record to update
            FlightBook.ThisFlight.Find(FlightNo);
            //display the data for this record
            txtFlightGroup.Text = FlightBook.ThisFlight.FlightGroup;
            txtFlightCode.Text = FlightBook.ThisFlight.FlightCode;
            txtFlightCompany.Text = FlightBook.ThisFlight.FlightCompany;
            txtFlightName.Text = FlightBook.ThisFlight.FlightName;
            txtDateAdded.Text = FlightBook.ThisFlight.DateAdded.ToString();
            chkActive.Checked = FlightBook.ThisFlight.Active;
        }
    }
}