using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DMUBMSClasses;

namespace DMUBMSFrontOffice
{
    public partial class DeleteHotel : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 HotelNo;

        //event handler for the load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the Hotel to be deleted from the session object
            HotelNo = Convert.ToInt32(Session["HotelNo"]);
        }

        //event handler for the yes button
        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteHotell();
            //redirect back to the main page
            Response.Redirect("DefaultHotel.aspx");
        }

        //event handler for the no button
        protected void btnNo_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("DefaultHotel.aspx");
        }

        void DeleteHotell()
        {
            //function to delete the selected record

            //create a new instance of the Hotel book
            clsHotelCollection HotelBook = new clsHotelCollection();
            //find the record to delete
            HotelBook.ThisHotel.Find(HotelNo);
            //delete the record
            HotelBook.Delete();
        }
    }
}