using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMUBMSFrontOffice
{
    public partial class Payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            //navigate back to PaymentConfirmation page
            Response.Redirect("PaymentConfirmation.aspx");
        }
    }
}