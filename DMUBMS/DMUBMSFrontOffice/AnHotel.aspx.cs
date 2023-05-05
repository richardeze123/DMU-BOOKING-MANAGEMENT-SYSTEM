using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMUBMSClasses;

namespace DMUBMSFrontOffice
{
    public partial class AnHotel : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 HotelNo;

        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the Hotel to be processed
            HotelNo = Convert.ToInt32(Session["HotelNo"]);
            if (IsPostBack == false)
            {
                //populate the list of RoomsAvailables
                DisplayRoomsAvailables();
                //if this is not a new record
                if (HotelNo != -1)
                {
                    //display the current data for the record
                    DisplayHotel();
                }
            }
        }

        //function for populating the RoomsAvailable drop down list
        void DisplayRoomsAvailables()
        {
            //create an instance of the RoomsAvailable Collection
            DMUBMSClasses.clsRoomsAvailableCollection RoomsAvailables = new DMUBMSClasses.clsRoomsAvailableCollection();
            //set the data source to the list of RoomsAvailables in the collection
            ddlRoomsAvailable.DataSource = RoomsAvailables.AllRoomsAvailables;
            //set the name of the primary key
            ddlRoomsAvailable.DataValueField = "RoomsAvailableNo";
            //set the data field to display
            ddlRoomsAvailable.DataTextField = "RoomsAvailable";
            //bind the data to the list
            ddlRoomsAvailable.DataBind();
        }

        //this is the event handler for the cancel button
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect to the main page
            Response.Redirect("DefaultHotel.aspx");
        }

        //event handler for the ok button
        protected void btnOk_Click(object sender, EventArgs e)
        {
            if (HotelNo == -1)
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
            clsHotelCollection HotelBook = new clsHotelCollection();
            //validate the data on the web form
            String Error = HotelBook.ThisHotel.Valid(txtStarRating.Text, txtPhoneNumber.Text, txtHotelAddress.Text, txtHotelName.Text, txtDateAdded.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                HotelBook.ThisHotel.StarRating = txtStarRating.Text;
                HotelBook.ThisHotel.PhoneNumber = txtPhoneNumber.Text;
                HotelBook.ThisHotel.HotelAddress = txtHotelAddress.Text;
                HotelBook.ThisHotel.HotelName = txtHotelName.Text;
                HotelBook.ThisHotel.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
                HotelBook.ThisHotel.Active = chkActive.Checked;
                HotelBook.ThisHotel.RoomsAvailableNo = Convert.ToInt32(ddlRoomsAvailable.SelectedValue);
                //add the record
                HotelBook.Add();
                //all done so redirect back to the main page
                Response.Redirect("DefaultHotel.aspx");
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
            DMUBMSClasses.clsHotelCollection HotelBook = new DMUBMSClasses.clsHotelCollection();
            //validate the data on the web form
            String Error = HotelBook.ThisHotel.Valid(txtStarRating.Text, txtPhoneNumber.Text, txtHotelAddress.Text, txtHotelName.Text, txtDateAdded.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //find the record to update
                HotelBook.ThisHotel.Find(HotelNo);
                //get the data entered by the user
                HotelBook.ThisHotel.StarRating = txtStarRating.Text;
                HotelBook.ThisHotel.PhoneNumber = txtPhoneNumber.Text;
                HotelBook.ThisHotel.HotelAddress = txtHotelAddress.Text;
                HotelBook.ThisHotel.HotelName = txtHotelName.Text;
                HotelBook.ThisHotel.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
                HotelBook.ThisHotel.Active = chkActive.Checked;
                HotelBook.ThisHotel.RoomsAvailableNo = Convert.ToInt32(ddlRoomsAvailable.SelectedValue);
                //update the record
                HotelBook.Update();
                //all done so redirect back to the main page
                Response.Redirect("DefaultHotel.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        void DisplayHotel()
        {
            //create an instance of the Hotel book
            clsHotelCollection HotelBook = new clsHotelCollection();
            //find the record to update
            HotelBook.ThisHotel.Find(HotelNo);
            //display the data for this record
            txtStarRating.Text = HotelBook.ThisHotel.StarRating;
            txtPhoneNumber.Text = HotelBook.ThisHotel.PhoneNumber;
            txtHotelAddress.Text = HotelBook.ThisHotel.HotelAddress;
            txtHotelName.Text = HotelBook.ThisHotel.HotelName;
            txtDateAdded.Text = HotelBook.ThisHotel.DateAdded.ToString();
            chkActive.Checked = HotelBook.ThisHotel.Active;
            ddlRoomsAvailable.SelectedValue = HotelBook.ThisHotel.RoomsAvailableNo.ToString();
        }

        protected void txtStarRating_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtHotelAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}