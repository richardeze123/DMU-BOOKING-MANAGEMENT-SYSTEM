using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DMUBMSClasses;

namespace DMUBMSTesting
{
    [TestClass]
    public class tstFlight
    {

        //good test data
        //create some test data to pass to the method
        string FlightGroup = "3";
        string FlightCode = "07777777777";
        string FlightCompany = "Test Data";
        string FlightName = "Test";
        string DateAdded = DateTime.Now.Date.ToString();


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //test to see that it exists
            Assert.IsNotNull(AnFlight);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnFlight.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnFlight.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.DateAdded, TestData);
        }


        [TestMethod]
        public void FlightNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnFlight.FlightNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.FlightNo, TestData);
        }


        [TestMethod]
        public void FlightGroupPropertyOK()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create some test data to assign to the property
            string TestData = "2";
            //assign the data to the property
            AnFlight.FlightGroup = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.FlightGroup, TestData);
        }

        [TestMethod]
        public void FlightNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create some test data to assign to the property
            string TestData = "Testt";
            //assign the data to the property
            AnFlight.FlightName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.FlightName, TestData);
        }


        [TestMethod]
        public void FlightCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create some test data to assign to the property
            string TestData = "07777777777";
            //assign the data to the property
            AnFlight.FlightCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.FlightCode, TestData);
        }

        [TestMethod]
        public void FlightCompanyPropertyOK()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //create some test data to assign to the property
            string TestData = "Test Data";
            //assign the data to the property
            AnFlight.FlightCompany = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.FlightCompany, TestData);
        }


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 FlightNo = 23;
            //invoke the method
            Found = AnFlight.Find(FlightNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestFlightNoFound()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightNo = 23;
            //invoke the method
            Found = AnFlight.Find(FlightNo);
            //check the Hotel no
            if (AnFlight.FlightNo != 23)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFlightCodeFound()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightNo = 23;
            //invoke the method
            Found = AnFlight.Find(FlightNo);
            //check the property
            if (AnFlight.FlightCode != "00000000002")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFlightCompanyFound()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightNo = 23;
            //invoke the method
            Found = AnFlight.Find(FlightNo);
            //check the property
            if (AnFlight.FlightCompany != "testt")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFlightNameFound()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightNo = 23;
            //invoke the method
            Found = AnFlight.Find(FlightNo);
            //check the property
            if (AnFlight.FlightName != "yyyyyy")
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
            clsFlight AnFlight = new clsFlight();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightNo = 23;
            //invoke the method
            Found = AnFlight.Find(FlightNo);
            //check the property
            if (AnFlight.DateAdded != Convert.ToDateTime("06/03/2023"))
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
            clsFlight AnFlight = new clsFlight();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightNo = 23;
            //invoke the method
            Found = AnFlight.Find(FlightNo);
            //check the property
            if (AnFlight.Active != true)
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
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FlightGroupMinLessOne()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FlightGroup = ""; //this should trigger an error
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FlightGroupMin()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FlightGroup = "1"; //this should be ok
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FlightGroupExtremeMax()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FlightGroup = "";
            FlightGroup = FlightGroup.PadRight(500, '1'); //this should fail
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
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
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
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
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
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
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
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
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FlightNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string FlightName = "";
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FlightNameMin()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FlightName = "a";
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FlightNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FlightName = "aa";
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FlightNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FlightName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FlightNameMax()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FlightName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FlightNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string FlightName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FlightNameMid()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FlightName = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void FlightCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string FlightCode = "";
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FlightCodeMin()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FlightCode = "0";
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FlightCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FlightCode = "07";
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FlightCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FlightCode = "";
            FlightCode = FlightCode.PadRight(19, '7');
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void FlightCodeMax()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FlightCode = "";
            FlightCode = FlightCode.PadRight(20, '7');
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FlightCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string FlightCode = "";
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FlightCodeMid()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FlightCode = "";
            FlightCode = FlightCode.PadRight(10, '7');
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void FlightCompanyMinLessOne()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string FlightCompany = "";
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FlightCompanyMin()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FlightCompany = "a";
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FlightCompanyMinPlusOne()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FlightCompany = "aa";
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void FlightCompanyMaxLessOne()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FlightCompany = "";
            FlightCompany = FlightCompany.PadRight(49, 'a');
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FlightCompanyMax()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FlightCompany = "";
            FlightCompany = FlightCompany.PadRight(50, 'a');
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FlightCompanyMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string FlightCompany = "";
            FlightCompany = FlightCompany.PadRight(51, 'a');
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void FlightCompanyMid()
        {
            //create an instance of the class we want to create
            clsFlight AnFlight = new clsFlight();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FlightCompany = "";
            FlightCompany = FlightCompany.PadRight(25, 'a');
            //invoke the method
            Error = AnFlight.Valid(FlightGroup, FlightCode, FlightCompany, FlightName, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}