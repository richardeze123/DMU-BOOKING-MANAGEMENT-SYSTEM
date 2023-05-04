using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMUBMSFrontOffice
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //redirect to the Hotel Page
            Response.Redirect("DefaultHotel.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //redirect to the Hotel Page
            Response.Redirect("DefaultCar.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //redirect to the Login page
            Response.Redirect("Login.aspx");
        }
    }
}