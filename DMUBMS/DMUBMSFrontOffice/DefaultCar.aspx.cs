using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMUBMSFrontOffice
{
    public partial class DefaultCar : System.Web.UI.Page
    {





        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["RegNo"] = -1;
            //redirect to the data entry page
            Response.Redirect("DefaultCar.aspx");
        }

        protected void lstCars_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {

            //var to store the primary key value of the record to be edited
            Int32 RegNo;
            //if a record has been selected from the list
            if (lstRegNo.SelectedIndex != -1)
            {
                //get the primary key value of the record to edit
                RegNo = Convert.ToInt32(lstRegNo.SelectedValue);
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

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected void btnHomePage_Click(object sender, EventArgs e)
        {
            //redirect to the Home Page
            Response.Redirect("HomePage.aspx");
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {

        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            
        }
    }
    }

    
