using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
    }
}