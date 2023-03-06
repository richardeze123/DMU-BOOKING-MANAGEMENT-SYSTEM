using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DMUBMSClasses;

namespace DMUBMSTesting
{
    [TestClass]
    public class tstHotel
    {

        //good test data
        //create some test data to pass to the method
        string StarRating = "3";
        string PhoneNumber = "07777777777";
        string HotelAddress = "Test Data";
        string HotelName = "Test";
        string DateAdded = DateTime.Now.Date.ToString();


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //test to see that it exists
            Assert.IsNotNull(AnHotel);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnHotel.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnHotel.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnHotel.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnHotel.DateAdded, TestData);
        }


        [TestMethod]
        public void HotelNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnHotel.HotelNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnHotel.HotelNo, TestData);
        }

        [TestMethod]
        public void RoomsAvailableNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnHotel.RoomsAvailableNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnHotel.RoomsAvailableNo, TestData);
        }

        [TestMethod]
        public void StarRatingPropertyOK()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //create some test data to assign to the property
            string TestData = "2";
            //assign the data to the property
            AnHotel.StarRating = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnHotel.StarRating, TestData);
        }

        [TestMethod]
        public void HotelNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //create some test data to assign to the property
            string TestData = "Testt";
            //assign the data to the property
            AnHotel.HotelName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnHotel.HotelName, TestData);
        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //create some test data to assign to the property
            string TestData = "07777777776";
            //assign the data to the property
            AnHotel.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnHotel.PhoneNumber, TestData);
        }

        [TestMethod]
        public void HotelAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //create some test data to assign to the property
            string TestData = "Test Data";
            //assign the data to the property
            AnHotel.HotelAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnHotel.HotelAddress, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 HotelNo = 23;
            //invoke the method
            Found = AnHotel.Find(HotelNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestHotelNoFound()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 HotelNo = 23;
            //invoke the method
            Found = AnHotel.Find(HotelNo);
            //check the Hotel no
            if (AnHotel.HotelNo != 23)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 HotelNo = 23;
            //invoke the method
            Found = AnHotel.Find(HotelNo);
            //check the property
            if (AnHotel.PhoneNumber != "00000000002")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHotelAddressFound()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 HotelNo = 23;
            //invoke the method
            Found = AnHotel.Find(HotelNo);
            //check the property
            if (AnHotel.HotelAddress != "testt")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHotelNameFound()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 HotelNo = 23;
            //invoke the method
            Found = AnHotel.Find(HotelNo);
            //check the property
            if (AnHotel.HotelName != "yyyyyy")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRoomsAvailableNoFound()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 HotelNo = 23;
            //invoke the method
            Found = AnHotel.Find(HotelNo);
            //check the property
            if (AnHotel.RoomsAvailableNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 HotelNo = 23;
            //invoke the method
            Found = AnHotel.Find(HotelNo);
            //check the property
            if (AnHotel.DateAdded != Convert.ToDateTime("06/03/2023"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 HotelNo = 23;
            //invoke the method
            Found = AnHotel.Find(HotelNo);
            //check the property
            if (AnHotel.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StarRatingMinLessOne()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StarRating = ""; //this should trigger an error
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StarRatingMin()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StarRating = "1"; //this should be ok
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StarRatingExtremeMax()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StarRating = "";
            StarRating = StarRating.PadRight(500, '1'); //this should fail
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HotelNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string HotelName = "";
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HotelNameMin()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string HotelName = "a";
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HotelNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string HotelName = "aa";
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HotelNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string HotelName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HotelNameMax()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string HotelName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HotelNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string HotelName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HotelNameMid()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string HotelName = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PhoneNumber = "";
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMin()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNumber = "0";
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNumber = "07";
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(19, '7');
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneNumberMax()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(20, '7');
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PhoneNumber = "";
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMid()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(10, '7');
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void HotelAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string HotelAddress = "";
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HotelAddressMin()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string HotelAddress = "a";
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HotelAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string HotelAddress = "aa";
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void HotelAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string HotelAddress = "";
            HotelAddress = HotelAddress.PadRight(49, 'a');
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HotelAddressMax()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string HotelAddress = "";
            HotelAddress = HotelAddress.PadRight(50, 'a');
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HotelAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string HotelAddress = "";
            HotelAddress = HotelAddress.PadRight(51, 'a');
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void HotelAddressMid()
        {
            //create an instance of the class we want to create
            clsHotel AnHotel = new clsHotel();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string HotelAddress = "";
            HotelAddress = HotelAddress.PadRight(25, 'a');
            //invoke the method
            Error = AnHotel.Valid(StarRating, PhoneNumber, HotelAddress, HotelName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}