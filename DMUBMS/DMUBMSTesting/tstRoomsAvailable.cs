using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DMUBMSClasses;

namespace DMUBMSTesting
{
    [TestClass]
    public class tstRoomsAvailable
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsRoomsAvailable ARoomsAvailable = new clsRoomsAvailable();
            //test to see that it exists
            Assert.IsNotNull(ARoomsAvailable);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsRoomsAvailable ARoomsAvailable = new clsRoomsAvailable();
            //create some test data to assign to the property
            string SomeRoomsAvailable = "25";
            //assign the data to the property
            ARoomsAvailable.RoomsAvailable = SomeRoomsAvailable;
            //test to see that the values are the same
            Assert.AreEqual(ARoomsAvailable.RoomsAvailable, SomeRoomsAvailable);
        }

        [TestMethod]
        public void CountNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsRoomsAvailable ARoomsAvailable = new clsRoomsAvailable();
            //create some test data to assign to the property
            Int32 RoomsAvailableNo = 1;
            //assign the data to the property
            ARoomsAvailable.RoomsAvailableNo = RoomsAvailableNo;
            //test to see that the values are the same
            Assert.AreEqual(ARoomsAvailable.RoomsAvailableNo, RoomsAvailableNo);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsRoomsAvailable ARoomsAvailable = new clsRoomsAvailable();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeRoomsAvailable = "25";
            //invoke the method
            Error = ARoomsAvailable.Valid(SomeRoomsAvailable);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomsAvailableMinLessOne()
        {
            //create an instance of the class we want to create
            clsRoomsAvailable ARoomsAvailable = new clsRoomsAvailable();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeRoomsAvailable = "";
            //invoke the method
            Error = ARoomsAvailable.Valid(SomeRoomsAvailable);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoomsAvailableMinBoundary()
        {
            //create an instance of the class we want to create
            clsRoomsAvailable ARoomsAvailable = new clsRoomsAvailable();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeRoomsAvailable = "1";
            //invoke the method
            Error = ARoomsAvailable.Valid(SomeRoomsAvailable);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomsAvailableMinPlusOne()
        {
            //create an instance of the class we want to create
            clsRoomsAvailable ARoomsAvailable = new clsRoomsAvailable();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeRoomsAvailable = "11";
            //invoke the method
            Error = ARoomsAvailable.Valid(SomeRoomsAvailable);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomsAvailableMaxLessOne()
        {
            //create an instance of the class we want to create
            clsRoomsAvailable ARoomsAvailable = new clsRoomsAvailable();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeRoomsAvailable = "hfgdtgfhdbavhfgetdgsfadqrihgygdndhbdtopljghndbhgf";
            //invoke the method
            Error = ARoomsAvailable.Valid(SomeRoomsAvailable);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void RoomsAvailableMaxBoundary()
        {
            //create an instance of the class we want to create
            clsRoomsAvailable ARoomsAvailable = new clsRoomsAvailable();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeRoomsAvailable = "hfgdtgfhdbavhfgetdgsfadqrihgygdndhbdtoplpjghndbhgf";
            //invoke the method
            Error = ARoomsAvailable.Valid(SomeRoomsAvailable);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomsAvailableMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsRoomsAvailable ARoomsAvailable = new clsRoomsAvailable();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeRoomsAvailable = "hfgdtgfhdbavhfgetdgsfadqridhgygdndhbdtoplpjghndbhgf";
            //invoke the method
            Error = ARoomsAvailable.Valid(SomeRoomsAvailable);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoomsAvailableMid()
        {
            //create an instance of the class we want to create
            clsRoomsAvailable ARoomsAvailable = new clsRoomsAvailable();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeRoomsAvailable = "hfgdtgfhdbavhfgetdgsfadqr";
            //invoke the method
            Error = ARoomsAvailable.Valid(SomeRoomsAvailable);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomsAvailableEtremeMax()
        {
            //create an instance of the class we want to create
            clsRoomsAvailable ARoomsAvailable = new clsRoomsAvailable();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeRoomsAvailable = "";
            //pad the string with characters
            SomeRoomsAvailable = SomeRoomsAvailable.PadRight(500, '1');
            //invoke the method
            Error = ARoomsAvailable.Valid(SomeRoomsAvailable);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
        }

    }
}