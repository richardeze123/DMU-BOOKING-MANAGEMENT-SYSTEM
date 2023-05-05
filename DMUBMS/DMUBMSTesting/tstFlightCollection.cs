using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DMUBMSClasses;

namespace DMUBMSTesting
{
    [TestClass]
    public class tstFlightCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsFlightCollection AllFlights = new clsFlightCollection();
            //test to see that it exists
            Assert.IsNotNull(AllFlights);
        }

        [TestMethod]
        public void FlightListOK()
        {
            //create an instance of the class we want to create
            clsFlightCollection AllFlights = new clsFlightCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsFlight> TestList = new List<clsFlight>();
            //add an item to the list
            //create the item of test data
            clsFlight TestItem = new clsFlight();
            //set its properties
            TestItem.Active = true;
            TestItem.FlightNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.FlightGroup = "1";
            TestItem.FlightName = "shangrila";
            TestItem.FlightCode = "07564635467";
            TestItem.FlightCompany = " 4 some town av";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllFlights.FlightList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllFlights.FlightList, TestList);
        }

        [TestMethod]
        public void ThisFlightPropertyOK()
        {
            //create an instance of the class we want to create
            clsFlightCollection AllFlights = new clsFlightCollection();
            //create some test data to assign to the property
            clsFlight TestFlight = new clsFlight();
            //set the properties of the test object
            TestFlight.Active = true;
            TestFlight.FlightNo = 1;
            TestFlight.DateAdded = DateTime.Now.Date;
            TestFlight.FlightGroup = "1";
            TestFlight.FlightName = "shangrila";
            TestFlight.FlightCode = "07564635467";
            TestFlight.FlightCompany = " 4 some town av";
            //assign the data to the property
            AllFlights.ThisFlight = TestFlight;
            //test to see that the two values are the same
            Assert.AreEqual(AllFlights.ThisFlight, TestFlight);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsFlightCollection AllFlights = new clsFlightCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsFlight> TestList = new List<clsFlight>();
            //add an item to the list
            //create the item of test data
            clsFlight TestItem = new clsFlight();
            //set its properties
            TestItem.Active = true;
            TestItem.FlightNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.FlightGroup = "1";
            TestItem.FlightName = "shangrila";
            TestItem.FlightCode = "07564635467";
            TestItem.FlightCompany = " 4 some town av";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllFlights.FlightList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllFlights.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsFlightCollection AllFlights = new clsFlightCollection();
            //create the item of test data
            clsFlight TestItem = new clsFlight();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.FlightNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.FlightGroup = "1";
            TestItem.FlightName = "shangrila";
            TestItem.FlightCode = "07564635467";
            TestItem.FlightCompany = " 4 some town av";
            //set ThisHotel to the test data
            AllFlights.ThisFlight = TestItem;
            //add the record
            PrimaryKey = AllFlights.Add();
            //set the primary key of the test data
            TestItem.FlightNo = PrimaryKey;
            //find the record
            AllFlights.ThisFlight.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllFlights.ThisFlight, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsFlightCollection AllFlights = new clsFlightCollection();
            //create the item of test data
            clsFlight TestItem = new clsFlight();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.FlightNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.FlightGroup = "1";
            TestItem.FlightName = "shangrila";
            TestItem.FlightCode = "07564635467";
            TestItem.FlightCompany = " 4 some town av";
            //set ThisHotel to the test data
            AllFlights.ThisFlight = TestItem;
            //add the record
            PrimaryKey = AllFlights.Add();
            //set the primary key of the test data
            TestItem.FlightNo = PrimaryKey;
            //find the record
            AllFlights.ThisFlight.Find(PrimaryKey);
            //delete the record
            AllFlights.Delete();
            //now find the record   
            Boolean Found = AllFlights.ThisFlight.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }


        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsFlightCollection AllFlights = new clsFlightCollection();
            //create the item of test data
            clsFlight TestItem = new clsFlight();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.FlightGroup = "1";
            TestItem.FlightName = "shangrila";
            TestItem.FlightCode = "07564635467";
            TestItem.FlightCompany = " 4 some town av";
            //set ThisHotel to the test data
            AllFlights.ThisFlight = TestItem;
            //add the record
            PrimaryKey = AllFlights.Add();
            //set the primary key of the test data
            TestItem.FlightNo = PrimaryKey;
            //modify the test data
            TestItem.Active = false;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.FlightGroup = "3";
            TestItem.FlightName = "ibis";
            TestItem.FlightCode = "07453645378";
            TestItem.FlightCompany = "4 some city av";
            //set the record based on the new test data
            AllFlights.ThisFlight = TestItem;
            //update the record
            AllFlights.Update();
            //find the record
            AllFlights.ThisFlight.Find(PrimaryKey);
            //test to see ThisHotel matches the test data
            Assert.AreEqual(AllFlights.ThisFlight, TestItem);
        }

        [TestMethod]
        public void ReportByFlightNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsFlightCollection AllFlights = new clsFlightCollection();
            //create an instance of the filtered data
            clsFlightCollection FilteredFlights = new clsFlightCollection();
            //apply a blank string (should return all records);
            FilteredFlights.ReportByFlightName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllFlights.Count, FilteredFlights.Count);
        }


        [TestMethod]
        public void ReportByFlightNameNoneFound()
        {
            //create an instance of the filtered data
            clsFlightCollection FilteredFlights = new clsFlightCollection();
            //apply a HotelName that doesn't exist
            FilteredFlights.ReportByFlightName("xxxxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredFlights.Count);
        }

        [TestMethod]
        public void ReportByFlightNameTestDataFound()
        {
            //create an instance of the filtered data
            clsFlightCollection FilteredFlights = new clsFlightCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a HotelName that doesn't exist
            FilteredFlights.ReportByFlightName("yyyyyy");
            //check that the correct number of records are found
            if (FilteredFlights.Count == 2)
            {
                //check that the first record is ID 2
                if (FilteredFlights.FlightList[0].FlightNo != 22)
                {
                    OK = false;
                }
                //check that the first record is ID 3
                if (FilteredFlights.FlightList[1].FlightNo != 23)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
