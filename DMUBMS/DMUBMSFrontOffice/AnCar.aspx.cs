using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMUBMSClasses;

namespace DMUBMSFrontOffice
{
    public partial class AnCar : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 RegNo;

        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the Hotel to be processed
            RegNo = Convert.ToInt32(Session["CarNo"]);
            if (IsPostBack == false)
            {
                //populate the list of Cars
                DisplayCar();
                //if this is not a new record
                if (RegNo != -1)
                {
                    //display the current data for the record
                    DisplayCar();
                }
            }
        }

        //function for populating the RoomsAvailable drop down list
        void DisplayCar()
        {
            //create an instance of the RoomsAvailable Collection
            DMUBMSClasses.clsCarCollection Cars = new DMUBMSClasses.clsCarCollection();
            //set the data source to the list of Cars in the collection
            txtRegNo.Text = "Brand";
            //set the name of the primary key
            //set the data field to display
            txtRegNo.Text = "RegNo";
            //bind the data to the list
            txtRegNo.DataBind();
        }




        //this is the event handler for the cancel button
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect to the main page
            Response.Redirect("DefaultCar.aspx");
        }
        //event handler for the ok button

        protected void txtRegNo_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            if (RegNo == -1)
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
        void Add()
        {
            //create an instance of the Hotel book
            clsCarCollection CarBook = new clsCarCollection();
            //validate the data on the web form
            String Error = CarBook.ThisCar.Valid(txtRegNo.Text, TxtModel.Text, txtPrice.Text, chkAvailable.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                CarBook.ThisCar.RegNo = txtRegNo.Text;
                CarBook.ThisCar.Model = TxtModel.Text;
                CarBook.ThisCar.Brand = txtBrand.Text;
                CarBook.ThisCar.Price = txtPrice.Text;
                CarBook.ThisCar.Available = chkAvailable.Text;
                //add the record
                CarBook.Add();
                //all done so redirect back to the main page
                Response.Redirect("DefaultCar.aspx");
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
            DMUBMSClasses.clsCarCollection CarBook = new DMUBMSClasses.clsCarCollection();
            //validate the data on the web form
            String Error = CarBook.ThisCar.Valid(txtRegNo.Text, TxtModel.Text, txtBrand.Text, txtPrice.Text, chkAvailable.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //find the record to update
                //get the data entered by the user
                CarBook.ThisCar.RegNo = txtRegNo.Text;
                CarBook.ThisCar.Model = TxtModel.Text;
                CarBook.ThisCar.Price = txtPrice.Text;
                CarBook.ThisCar.Brand = txtBrand.Text;
                CarBook.ThisCar.Available = chkAvailable.Text;
                //update the record
               CarBook.Update();
                //all done so redirect back to the main page
                Response.Redirect("DefaultHotel.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }


    }

}



