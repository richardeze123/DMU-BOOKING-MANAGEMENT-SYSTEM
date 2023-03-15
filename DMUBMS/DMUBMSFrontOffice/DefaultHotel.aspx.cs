using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMUBMSClasses;

namespace DMUBMSFrontOffice
{
    public partial class DefaultHotel : System.Web.UI.Page
    {
        //this function handles the load event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayHotels();
            }
        }

        void DisplayHotels()
        {
            //create an instance of the RoomsAvailable Collection
            DMUBMSClasses.clsHotelCollection Hotels = new DMUBMSClasses.clsHotelCollection();
            //set the data source to the list of RoomsAvailables in the collection
            lstHotels.DataSource = Hotels.HotelList;
            //set the name of the primary key
            lstHotels.DataValueField = "HotelNo";
            //set the data field to display
            lstHotels.DataTextField = "HotelName";
            //bind the data to the list
            lstHotels.DataBind();
        }

        //event handler for the add button
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["HotelNo"] = -1;
            //redirect to the data entry page
            Response.Redirect("AnHotel.aspx");
        }

        //event handler for the edit button
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 HotelNo;
            //if a record has been selected from the list
            if (lstHotels.SelectedIndex != -1)
            {
                //get the primary key value of the record to edit
                HotelNo = Convert.ToInt32(lstHotels.SelectedValue);
                //store the data in the session object
                Session["HotelNo"] = HotelNo;
                //redirect to the edit page
                Response.Redirect("AnHotel.aspx");
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
            Int32 HotelNo;
            //if a record has been selected from the list
            if (lstHotels.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                HotelNo = Convert.ToInt32(lstHotels.SelectedValue);
                //store the data in the session object
                Session["HotelNo"] = HotelNo;
                //redirect to the delete page
                Response.Redirect("DeleteHotel.aspx");
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

        protected void lstHotels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //event handler for the apply button
        protected void btnApply_Click(object sender, EventArgs e)
        {
            //declare var to store the record count
            Int32 RecordCount;
            //assign the results of the DisplayHotels function to the record count var
            RecordCount = DisplayHotels(txtHotelName.Text);
            //display the number of records found
            lblError.Text = RecordCount + " records found";
        }

        //event hanlder for the display all button
        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //var to store the record count
            Int32 RecordCount;
            //assign the results of the DisplayHotels function to the record count var
            RecordCount = DisplayHotels("");
            //display the number of records found
            lblError.Text = RecordCount + " records in the database";
            //clear the post code filter text box
            txtHotelName.Text = "";
        }

        //function use to populate the list box
        Int32 DisplayHotels(string HotelNameFilter)
        {
            ///this function accepts one parameter - the HotelName to filter the list on
            ///it populates the list box with data from the middle layer class
            ///it returns a single value, the number of records found

            //create a new instance of the clsHotel
            clsHotelCollection MyHotelBook = new clsHotelCollection();
            //var to store the count of records
            Int32 RecordCount;
            //var to store the StarRating
            string StarRating;
            //var to store the PhoneNumber
            string PhoneNumber;
            //var to store the HotelName
            string HotelName;
            //var to store the primary key value
            string HotelNo;
            //var to store the index
            Int32 Index = 0;
            //clear the list of any existing items
            lstHotels.Items.Clear();
            //call the filter by HotelName method
            MyHotelBook.ReportByHotelName(HotelNameFilter);
            //get the count of records found
            RecordCount = MyHotelBook.Count;
            //loop through each record found using the index to point to each record in the data table
            while (Index < RecordCount)
            {
                //get the StarRating from the query results
                StarRating = Convert.ToString(MyHotelBook.HotelList[Index].StarRating);
                //get the PhoneNumber from the query results
                PhoneNumber = Convert.ToString(MyHotelBook.HotelList[Index].PhoneNumber);
                //get the HotelName from the query results
                HotelName = Convert.ToString(MyHotelBook.HotelList[Index].HotelName);
                //get the HotelNo from the query results
                HotelNo = Convert.ToString(MyHotelBook.HotelList[Index].HotelNo);
                //set up a new object of class list item 
                ListItem NewItem = new ListItem(StarRating + " " + PhoneNumber + " " + HotelName, HotelNo);
                //add the new item to the list
                lstHotels.Items.Add(NewItem);
                //increment the index
                Index++;
            }
            //return the number of records found
            return RecordCount;
        }
    }
}