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
        //this function will load the event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
            //clear any existing error messages
            lblError.Text = "";
            //if this is the first time the page has been displayed
            if (IsPostBack == false)
            {
                //populate the list and display the number of records found
                lblError.Text = DisplayCars("") + " records in the database";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}