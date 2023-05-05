using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DMUBMSClasses;

namespace DMUBMSTesting
{
    [TestClass]
    public class tstCarCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCars);
        }

        [TestMethod]
        public void CarListOk()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCar> TestList = new List<clsCar>();
            //add an item to the list
            //create the item of test data
            clsCar TestItem = new clsCar();
            //set its properties
            TestItem.Available = "";
            TestItem.RegNo = "wv646yu";
            TestItem.Model = "1 serires";
            TestItem.Brand = "BMW";
            TestItem.Price = "£600";
            TestList.Add(TestItem);
            //assign the data to the property
            AllCars.CarList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCars.CarList, TestList);
        }

        [TestMethod]
        public void ThisCarPropertyOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create some test data to assign to the property
            clsCar TestCar = new clsCar();
            //set the properties of the test object
            TestCar.Available = "";
            TestCar.RegNo = "wv646yu";
            TestCar.Model = "1 series";
            TestCar.Brand = "1";
            TestCar.Price = "£600";
            //assign the data to the property
            AllCars.ThisCar = TestCar;
            //test to see that the two values are the same
            Assert.AreEqual(AllCars.ThisCar, TestCar);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCar> TestList = new List<clsCar>();
            //add an item to the list
            //create the item of test data
            clsCar TestItem = new clsCar();
            //set its properties
            TestItem.Available = "";
            TestItem.RegNo = "wv646yu";
            TestItem.Model = "1 series";
            TestItem.Brand = "BMW";
            TestItem.Price = "£600";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCars.CarList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCars.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create the item of test data
            clsCar TestItem = new clsCar();
            //var to store the primary key
            string PrimaryKey = "";
            //set its properties
            TestItem.Available = "";
            TestItem.RegNo = "wv646yu";
            TestItem.Model = "1 series";
            TestItem.Brand = "BMW";
            TestItem.Price = "£600";
            //set ThisHotel to the test data
            AllCars.ThisCar = TestItem;
            //add the record
            //set the primary key of the test data
            TestItem.RegNo = PrimaryKey;
            //find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCars.ThisCar, TestItem);
        }

        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create the item of test data
            clsCar TestItem = new clsCar();
            //var to store the primary key
            string PrimaryKey = "";
            //set its properties
            TestItem.Available = "";
            TestItem.RegNo = "wv646yu";
            TestItem.Model = "1 series";
            TestItem.Brand = "BMW";
            TestItem.Price = "£600";
            //set ThisHotel to the test data
            AllCars.ThisCar = TestItem;
            //add the record
            //set the primary key of the test data
            TestItem.RegNo = PrimaryKey;
            //find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //delete the record
            AllCars.Delete();
            //now find the record   
            Boolean Found = AllCars.ThisCar.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create the item of test data
            clsCar TestItem = new clsCar();
            //var to store the primary key
            String PrimaryKey = "";
            //set its properties
            TestItem.RegNo = "wv646yu";
            TestItem.Model = "1 series";
            TestItem.Brand = "BMW";
            TestItem.Available = "";
            TestItem.Price = "£600";
            //set ThisHotel to the test data
            AllCars.ThisCar = TestItem;
            //add the record

            //set the primary key of the test data
            TestItem.RegNo = PrimaryKey;
            //modify the test data
            TestItem.RegNo = "wv646yu";
            TestItem.Model = "1 series";
            TestItem.Brand = "BMW";
            TestItem.Available = "";
            TestItem.Price = "£600";
            //set the record based on the new test data
            AllCars.ThisCar = TestItem;
            //update the record
            AllCars.Update();
            //find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //test to see ThisCar matches the test data
            Assert.AreEqual(AllCars.ThisCar, TestItem);
        }

        [TestMethod]
        public void ReportByCarRegMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsCarCollection AllCars = new clsCarCollection();
            //create an instance of the filtered data
            clsCarCollection FilteredCrars = new clsCarCollection();
            //apply a blank string (should return all records);
            FilteredCrars.ReportByRegNo("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCars.Count, FilteredCrars.Count);
        }

        [TestMethod]
        public void ReportByRegNoNoneFound()
        {
            //create an instance of the filtered data
            clsCarCollection FilteredCars = new clsCarCollection();
            //apply a CarReg that doesn't exist
            FilteredCars.ReportByRegNo("xxxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCars.Count);
        }


        }
    
    }

