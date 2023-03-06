using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DMUBMSClasses;

namespace DMUBMSTesting
{
    [TestClass]
    public class tstotelCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsHotelCollection AllHotels = new clsHotelCollection();
            //test to see that it exists
            Assert.IsNotNull(AllHotels);
        }

        [TestMethod]
        public void HotelListOK()
        {
            //create an instance of the class we want to create
            clsHotelCollection AllHotels = new clsHotelCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsHotel> TestList = new List<clsHotel>();
            //add an item to the list
            //create the item of test data
            clsHotel TestItem = new clsHotel();
            //set its properties
            TestItem.Active = true;
            TestItem.HotelNo = 1;
            TestItem.RoomsAvailableNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StarRating = "1";
            TestItem.HotelName = "shangrila";
            TestItem.PhoneNumber = "07564635467";
            TestItem.HotelAddress = " 4 some town av";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllHotels.HotelList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllHotels.HotelList, TestList);
        }

        [TestMethod]
        public void ThisHotelPropertyOK()
        {
            //create an instance of the class we want to create
            clsHotelCollection AllHotels = new clsHotelCollection();
            //create some test data to assign to the property
            clsHotel TestHotel = new clsHotel();
            //set the properties of the test object
            TestHotel.Active = true;
            TestHotel.HotelNo = 1;
            TestHotel.RoomsAvailableNo = 1;
            TestHotel.DateAdded = DateTime.Now.Date;
            TestHotel.StarRating = "1";
            TestHotel.HotelName = "shangrila";
            TestHotel.PhoneNumber = "07564635467";
            TestHotel.HotelAddress = " 4 some town av";
            //assign the data to the property
            AllHotels.ThisHotel = TestHotel;
            //test to see that the two values are the same
            Assert.AreEqual(AllHotels.ThisHotel, TestHotel);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsHotelCollection AllHotels = new clsHotelCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsHotel> TestList = new List<clsHotel>();
            //add an item to the list
            //create the item of test data
            clsHotel TestItem = new clsHotel();
            //set its properties
            TestItem.Active = true;
            TestItem.HotelNo = 1;
            TestItem.RoomsAvailableNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StarRating = "1";
            TestItem.HotelName = "shangrila";
            TestItem.PhoneNumber = "07564635467";
            TestItem.HotelAddress = " 4 some town av";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllHotels.HotelList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllHotels.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsHotelCollection AllHotels = new clsHotelCollection();
            //create the item of test data
            clsHotel TestItem = new clsHotel();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.HotelNo = 1;
            TestItem.RoomsAvailableNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StarRating = "1";
            TestItem.HotelName = "shangrila";
            TestItem.PhoneNumber = "07564635467";
            TestItem.HotelAddress = " 4 some town av";
            //set ThisHotel to the test data
            AllHotels.ThisHotel = TestItem;
            //add the record
            PrimaryKey = AllHotels.Add();
            //set the primary key of the test data
            TestItem.HotelNo = PrimaryKey;
            //find the record
            AllHotels.ThisHotel.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllHotels.ThisHotel, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsHotelCollection AllHotels = new clsHotelCollection();
            //create the item of test data
            clsHotel TestItem = new clsHotel();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.HotelNo = 1;
            TestItem.RoomsAvailableNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StarRating = "1";
            TestItem.HotelName = "shangrila";
            TestItem.PhoneNumber = "07564635467";
            TestItem.HotelAddress = " 4 some town av";
            //set ThisHotel to the test data
            AllHotels.ThisHotel = TestItem;
            //add the record
            PrimaryKey = AllHotels.Add();
            //set the primary key of the test data
            TestItem.HotelNo = PrimaryKey;
            //find the record
            AllHotels.ThisHotel.Find(PrimaryKey);
            //delete the record
            AllHotels.Delete();
            //now find the record   
            Boolean Found = AllHotels.ThisHotel.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }


        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsHotelCollection AllHotels = new clsHotelCollection();
            //create the item of test data
            clsHotel TestItem = new clsHotel();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.RoomsAvailableNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StarRating = "1";
            TestItem.HotelName = "shangrila";
            TestItem.PhoneNumber = "07564635467";
            TestItem.HotelAddress = "4 some town av";
            //set ThisHotel to the test data
            AllHotels.ThisHotel = TestItem;
            //add the record
            PrimaryKey = AllHotels.Add();
            //set the primary key of the test data
            TestItem.HotelNo = PrimaryKey;
            //modify the test data
            TestItem.Active = false;
            TestItem.RoomsAvailableNo = 3;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StarRating = "3";
            TestItem.HotelName = "ibis";
            TestItem.PhoneNumber = "07453645378";
            TestItem.HotelAddress = "4 some city av";
            //set the record based on the new test data
            AllHotels.ThisHotel = TestItem;
            //update the record
            AllHotels.Update();
            //find the record
            AllHotels.ThisHotel.Find(PrimaryKey);
            //test to see ThisHotel matches the test data
            Assert.AreEqual(AllHotels.ThisHotel, TestItem);
        }

        [TestMethod]
        public void ReportByHotelNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsHotelCollection AllHotels = new clsHotelCollection();
            //create an instance of the filtered data
            clsHotelCollection FilteredHotels = new clsHotelCollection();
            //apply a blank string (should return all records);
            FilteredHotels.ReportByHotelName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllHotels.Count, FilteredHotels.Count);
        }


        [TestMethod]
        public void ReportByHotelNameNoneFound()
        {
            //create an instance of the filtered data
            clsHotelCollection FilteredHotels = new clsHotelCollection();
            //apply a HotelName that doesn't exist
            FilteredHotels.ReportByHotelName("xxxxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredHotels.Count);
        }

        [TestMethod]
        public void ReportByHotelNameTestDataFound()
        {
            //create an instance of the filtered data
            clsHotelCollection FilteredHotels = new clsHotelCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a HotelName that doesn't exist
            FilteredHotels.ReportByHotelName("yyyyyy");
            //check that the correct number of records are found
            if (FilteredHotels.Count == 2)
            {
                //check that the first record is ID 2
                if (FilteredHotels.HotelList[0].HotelNo != 22)
                {
                    OK = false;
                }
                //check that the first record is ID 3
                if (FilteredHotels.HotelList[1].HotelNo != 23)
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