using DMUBMSClasses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMUBMSFrontOffice
{
    public partial class EMailViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //create an instance of the security class
            clsSecurity Sec = new clsSecurity();
            //get the current data from the session
            Sec = (clsSecurity)Session["Sec"];
            //display the email contents on the page
            Response.Write("To: ");
            Response.Write(Sec.EMailMessage.Recipient);
            Response.Write("</br>");
            Response.Write("From: ");
            Response.Write(Sec.EMailMessage.Sender);
            Response.Write("</br>");
            Response.Write("Subject: ");
            Response.Write(Sec.EMailMessage.Subject);
            Response.Write("</br>");
            Response.Write("Body: ");
            Response.Write(Sec.EMailMessage.Body);
            Response.Write("</br>");
        }
    }
}