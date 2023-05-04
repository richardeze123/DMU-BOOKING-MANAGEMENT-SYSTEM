using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMUBMSClasses;

namespace DMUBMSFrontOffice
{
    public partial class DefaultFlight : System.Web.UI.Page
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

        //event handler for the add button
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["FlightNo"] = -1;
            //redirect to the data entry page
            Response.Redirect("AnFlight.aspx");
        }

        //event handler for the edit button
        protected void btnEdit_Click(object sender, EventArgs e)
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
                //redirect to the edit page
                Response.Redirect("AnFlight.aspx");
            }
            else//if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to edit from the list";
            }
        }

        //event handler for the delete button
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 FlightNo;
            //if a record has been selected from the list
            if (lstFlights.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                FlightNo = Convert.ToInt32(lstFlights.SelectedValue);
                //store the data in the session object
                Session["FlightNo"] = FlightNo;
                //redirect to the delete page
                Response.Redirect("DeleteFlight.aspx");
            }
            else //if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnHomePage_Click(object sender, EventArgs e)
        {
            //redirect to the Home Page
            Response.Redirect("HomePage.aspx");
        }

        protected void lstFlights_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //event handler for the apply button
        protected void btnApply_Click(object sender, EventArgs e)
        {
            //declare var to store the record count
            Int32 RecordCount;
            //assign the results of the DisplayHotels function to the record count var
            RecordCount = DisplayFlights(txtFlightName.Text);
            //display the number of records found
            lblError.Text = RecordCount + " records found";
        }

        //event hanlder for the display all button
        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //var to store the record count
            Int32 RecordCount;
            //assign the results of the DisplayHotels function to the record count var
            RecordCount = DisplayFlights("");
            //display the number of records found
            lblError.Text = RecordCount + " records in the database";
            //clear the post code filter text box
            txtFlightName.Text = "";
        }

        //function use to populate the list box
        Int32 DisplayFlights(string FlightNameFilter)
        {
            ///this function accepts one parameter - the HotelName to filter the list on
            ///it populates the list box with data from the middle layer class
            ///it returns a single value, the number of records found

            //create a new instance of the clsHotel
            clsFlightCollection MyFlightBook = new clsFlightCollection();
            //var to store the count of records
            Int32 RecordCount;
            //var to store the StarRating
            string FlightGroup;
            //var to store the PhoneNumber
            string FlightCode;
            //var to store the HotelName
            string FlightName;
            //var to store the primary key value
            string FlightNo;
            //var to store the index
            Int32 Index = 0;
            //clear the list of any existing items
            lstFlights.Items.Clear();
            //call the filter by HotelName method
            MyFlightBook.ReportByFlightName(FlightNameFilter);
            //get the count of records found
            RecordCount = MyFlightBook.Count;
            //loop through each record found using the index to point to each record in the data table
            while (Index < RecordCount)
            {
                //get the StarRating from the query results
                FlightGroup = Convert.ToString(MyFlightBook.FlightList[Index].FlightGroup);
                //get the PhoneNumber from the query results
                FlightCode = Convert.ToString(MyFlightBook.FlightList[Index].FlightCode);
                //get the HotelName from the query results
                FlightName = Convert.ToString(MyFlightBook.FlightList[Index].FlightName);
                //get the HotelNo from the query results
                FlightNo = Convert.ToString(MyFlightBook.FlightList[Index].FlightNo);
                //set up a new object of class list item 
                ListItem NewItem = new ListItem(FlightGroup + " " + FlightCode + " " + FlightName, FlightNo);
                //add the new item to the list
                lstFlights.Items.Add(NewItem);
                //increment the index
                Index++;
            }
            //return the number of records found
            return RecordCount;
        }

        protected void txtFlightName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtFlightName_TextChanged1(object sender, EventArgs e)
        {

        }
    }
}