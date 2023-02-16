using DMUBMSClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMUBMSFrontOffice
{
    public partial class ActivateAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the email from the query string
            string EMail = Request.QueryString["EMail"];
            //get the temp password from the query string
            string TempPW = Request.QueryString["TempPW"];
            //create an instance of the security class
            clsSecurity Sec = new clsSecurity();
            //activate the account
            lblError.Text = Sec.ActivateAccount(EMail, TempPW);
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //go back to the main page
            Response.Redirect("Login.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //go back to the main page
            Response.Redirect("Login.aspx");
        }
    }
}