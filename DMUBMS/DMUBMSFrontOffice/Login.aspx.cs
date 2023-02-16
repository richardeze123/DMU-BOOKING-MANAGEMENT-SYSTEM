using DMUBMSClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMUBMSFrontOffice
{
    public partial class Login : System.Web.UI.Page
    {
        //create a copy of the security object with page level scope
        clsSecurity Sec;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the current security state from the session
            Sec = (clsSecurity)Session["Sec"];
        }

        protected void btnCanel_Click(object sender, EventArgs e)
        {
            //navigate back to default
            Response.Redirect("Login.aspx");
        }

        protected void btnReSend_Click(object sender, EventArgs e)
        {
            //navigate to the re-send page
            Response.Redirect("ReSet.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //try to sign in and record any errors
            String Error = Sec.Login(txtEMail.Text, txtPassword.Text);
            //if there were no errors
            if (Error == "")
            {
                //redirect to the main page
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                //otherwise display any errors
                lblError.Text = Error;
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //try to sign in and record any errors
            String Error = Sec.Login(txtEMail.Text, txtPassword.Text);
            //if there were no errors
            if (Error == "")
            {
                //redirect to the main page
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                //otherwise display any errors
                lblError.Text = Error;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //redirect to the register page
            Response.Redirect("Register.aspx");
        }
    }
}