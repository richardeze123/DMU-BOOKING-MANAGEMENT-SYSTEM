using DMUBMSClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMUBMSFrontOffice
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        //create an instance of the security class
        clsSecurity Sec;
        //vars to store temp password and email address
        string TempPW;
        string EMail;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the temp pw from the query string
            TempPW = Request.QueryString["TempPW"];
            //get the email address from the query string
            EMail = Request.QueryString["EMail"];
            //if the temp password isn't null
            if (TempPW != null)
            {
                //initialise the sceurity object
                Sec = new clsSecurity();
                //hide the current password label and text box (this is a user who has forgotten their password)
                lblCurrentPassword.Visible = false;
                txtCurrentPassword.Visible = false;
            }
            else
            {
                //get the security state from the session
                Sec = (clsSecurity)Session["Sec"];
                //if it isn't authenticated
                if (IsAuthenticated(Sec) == false)
                {
                    //redirect back to the login page as the user hasn't got permission to use this page
                    Response.Redirect("Login.aspx");
                }
            }

            Boolean IsAuthenticated(clsSecurity Sec)
            {
                //tests to see if the current login is authenticated to use this page

                //var to store the state of authentication assume all is well i.e. true
                Boolean Auth = true;
                //if the security object is not null
                if (Sec != null)
                {
                    //if the user isn't authenticated
                    if (Sec.Authenticated == false)
                    {
                        //set state to false
                        Auth = false;
                    }
                }
                else
                {
                    //else set authenticated to false
                    Auth = false;
                }
                //return the authentication state
                return Auth;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //go back to the login page
            Response.Redirect("Login.aspx");
        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            ///changes the current password 
            ///if there is no temp passsword supplied then treat it as a typical user 
            ///wanting to change their password
            ///if there is a temp password then treat it as a user who 
            ///has forgotten their password

            //var to store any errors
            string Error;
            //if there is no temp password
            if (TempPW == null)
            {
                //change the password as a typical user
                Error = Sec.ChangePassword(Sec.UserEMail, txtCurrentPassword.Text, txtPassword1.Text, txtPassword2.Text);
            }
            else
            {
                //change the password based on a forgotten password
                Error = Sec.ChangePasswordWithTempPW(EMail, TempPW, txtPassword1.Text, txtPassword2.Text);
            }
            //display any errors
            lblError.Text = Error;
        }
    }
}