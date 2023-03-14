using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMUBMSFrontOffice
{
    public partial class BookingHotel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPAYMENT_Click1(object sender, EventArgs e)
        {

        }

        protected void btnPAYMENT_Click(object sender, EventArgs e)
        {
            //navigate to the payment page
            Response.Redirect("Payment.aspx");
        }
    }
}