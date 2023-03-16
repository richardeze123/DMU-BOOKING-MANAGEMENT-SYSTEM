using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMUBMSFrontOffice
{
    public partial class indexLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLOGIN_Click(object sender, EventArgs e)
        {
            //navigate to the Home page page
            Response.Redirect("index.html");
        }
    }
}