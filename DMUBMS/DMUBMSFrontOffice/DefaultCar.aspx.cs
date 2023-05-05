using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMUBMSClasses;

namespace DMUBMSFrontOffice
{
    public partial class DefaultCar : System.Web.UI.Page
    {
        //this function handles the load event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayRegNo();
            }
            void DisplayRegNo()
            {
                //create an instance of the RegNo
                DMUBMSClasses.clsCarCollection Cars = new DMUBMSClasses.clsCarCollection();
                //set the data source to the list of Cars in the collection
                lstCars.DataSource = Cars.CarList;
                //set the name of the primary key
                lstCars.DataValueField = "RegNo";
                //set the data field to display
                lstCars.DataTextField = "Brand";
                //bind the data to the list
                lstCars.DataBind();
            }
        }
        protected void btnApply_Click(object sender, EventArgs e)
        {
            //declare var to store the record count
            Int32 RecordCount;
            //assign the results of the DisplayRegNo function to the record count var
            RecordCount = DisplayRegNo(txtRegNo.Text);
            //display the number of records found
            lblError.Text = RecordCount + " records found";
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["RegNo"] = -1;
            //redirect to the data entry page
            Response.Redirect("AnCar.aspx");


        }

        //event handler for the edit button
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            string RegNo; ;
            //if a record has been selected from the list
            if (lstCars.SelectedIndex != -1)
            {
                //get the primary key value of the record to edit
                RegNo = Convert.ToString(lstCars.SelectedValue);
                //store the data in the session object
                Session["RegNo"] = RegNo;
                //redirect to the edit page
                Response.Redirect("AnCar.aspx");
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
            string RegNo;
            //if a record has been selected from the list
            if (lstCars.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                RegNo = Convert.ToString(lstCars.SelectedValue);
                //store the data in the session object
                Session["RegNo"] = RegNo;
                //redirect to the delete page
                Response.Redirect("Deletecar.aspx");
            }
            else //if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //var to store the record count
            Int32 RecordCount;
            //assign the results of the DisplayHotels function to the record count var
            RecordCount = DisplayRegNo("");
            //display the number of records found
            lblError.Text = RecordCount + " records in the database";
            //clear the post code filter text box
            txtRegNo.Text = "";
        }
        Int32 DisplayRegNo(string RegNoFilter)
        {
            ///this function accepts one parameter - the CarReg to filter the list on
            ///it populates the list box with data from the middle layer class
            ///it returns a single value, the number of records found

            //create a new instance of the clsCar
            clsCarCollection MyCarBook = new clsCarCollection();
            //var to store the count of records
            Int32 RecordCount;
            //var to store the RegNo
            string RegNo;
            //var to store the Brand
            string Brand;
            //var to store the Price
            string Price;
            //var to store the primary key value
            string Model;
            //var to store the index
            Int32 Index = 1;
            //clear the list of any existing items
            lstCars.Items.Clear();
            //call the filter by HotelName method
            MyCarBook.ReportByRegNo(RegNoFilter);
            //get the count of records found
            RecordCount = MyCarBook.Count;
            //loop through each record found using the index to point to each record in the data table
            while (Index < RecordCount)
            {
                //get the StarRating from the query results
                RegNo = Convert.ToString(MyCarBook.CarList[Index].RegNo);
                //get the brand from the query results
                Brand = Convert.ToString(MyCarBook.CarList[Index].Brand);
                //get the price from the query results
                Price = Convert.ToString(MyCarBook.CarList[Index].Price);
                //get the model from the query results
                Model = Convert.ToString(MyCarBook.CarList[Index].Model);
                //set up a new object of class list item 
                ListItem NewItem = new ListItem(RegNo + " " + Brand + " " + Price, Model);
                //add the new item to the list
                lstCars.Items.Add(NewItem);
                //increment the index
                Index++;
            }
            //return the number of records found
            return RecordCount;
        }

        protected void txtRegNo_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnHomePage_Click(object sender, EventArgs e)
        {
            //redirect to the Home Page
            Response.Redirect("HomePage.aspx");
        }

        protected void lstCars_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}




