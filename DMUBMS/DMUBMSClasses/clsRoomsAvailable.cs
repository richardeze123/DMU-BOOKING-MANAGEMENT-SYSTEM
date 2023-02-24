using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMUBMSClasses
{
    class clsRoomsAvailable
    {
        public string RoomsAvailable { get; set; }

        public int RoomNo { get; set; }

        public string Valid(string someRoomsAvailable)
        {
            //string variable to store the error message
            string Error = "";
            //if the name of the RoomsAvailable is more than 50 characters
            if (someRoomsAvailable.Length > 50)
            {
                //return an error message
                Error = "The RoomsAvailable cannot have more than 50 characters";
            }
            if (someRoomsAvailable.Length == 0)
            {
                //return an error message
                Error = "The RoomsAvailable name may not be blank!";
            }
            return Error;
        }
    }
}
