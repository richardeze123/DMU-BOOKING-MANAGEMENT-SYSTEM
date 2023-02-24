using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMUBMSClasses
{
    class clsRoomsAvailableCollection
    {
        //private data member for the allRoomsAvailable list
        private List<clsRoomsAvailable> mAllRoomsAvailables = new List<clsRoomsAvailable>();

        //public constructor for the class
        public clsRoomsAvailableCollection()
        {
            //create an instance of the dataconnection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to get the list of data
            DB.Execute("sproc_tblRoomsAvailable_SelectAll");
            //get the count of records
            Int32 RecordCount = DB.Count;
            //set up the index for the loop
            Int32 Index = 0;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a new instance of the RoomsAvailable class
                clsRoomsAvailable ARoomsAvailable = new clsRoomsAvailable();
                //get the RoomsAvailable name
                ARoomsAvailable.RoomsAvailable = DB.DataTable.Rows[Index]["RoomsAvailable"].ToString();
                //get the primary key
                ARoomsAvailable.RoomNo = Convert.ToInt32(DB.DataTable.Rows[Index]["RoomNo"]);
                //add the RoomsAvailable to the private data member
                mAllRoomsAvailables.Add(ARoomsAvailable);
                //increment the index
                Index++;
            }
        }

        //public property for Count
        public int Count
        {
            get
            {
                //return the count property of the private list
                return mAllRoomsAvailables.Count;
            }
            set
            {
                //we will look at this in a moment!
            }
        }

        //public property for allRoomsAvailables
        public List<clsRoomsAvailable> AllRoomsAvailables
        {
            //getter sends data to requesting code
            get
            {
                //return the private data mamber
                return mAllRoomsAvailables;
            }
            //setter accepts data from other objects
            set
            {
                //assign the incoming value to the private data member
                mAllRoomsAvailables = value;
            }
        }
    }
}
