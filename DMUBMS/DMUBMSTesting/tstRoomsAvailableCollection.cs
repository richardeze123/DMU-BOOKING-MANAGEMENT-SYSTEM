using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DMUBMSClasses;

namespace DMUBMSTesting
{
    [TestClass]
    public class tstRoomsAvailableCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsRoomsAvailableCollection AllRoomsAvailables = new clsRoomsAvailableCollection();
            //test to see that it exists
            Assert.IsNotNull(AllRoomsAvailables);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsRoomsAvailableCollection AllRoomsAvailables = new clsRoomsAvailableCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 50;
            //assign the data to the property
            AllRoomsAvailables.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllRoomsAvailables.Count, SomeCount);
        }

        [TestMethod]
        public void AllRoomsAvailablesOK()
        {
            //create an instance of the class we want to create
            clsRoomsAvailableCollection RoomsAvailables = new clsRoomsAvailableCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsRoomsAvailable> TestList = new List<clsRoomsAvailable>();
            //add an item to the list
            //create the item of test data
            clsRoomsAvailable TestItem = new clsRoomsAvailable();
            //set its properties
            TestItem.RoomsAvailableNo = 1;
            TestItem.RoomsAvailable = "25";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            RoomsAvailables.AllRoomsAvailables = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(RoomsAvailables.AllRoomsAvailables, TestList);
        }

        [TestMethod]
        public void CountMatchesList()
        {
            //create an instance of the class we want to create
            clsRoomsAvailableCollection RoomsAvailables = new clsRoomsAvailableCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsRoomsAvailable> TestList = new List<clsRoomsAvailable>();
            //add an item to the list
            //create the item of test data
            clsRoomsAvailable TestItem = new clsRoomsAvailable();
            //set its properties
            TestItem.RoomsAvailableNo = 1;
            TestItem.RoomsAvailable = "25";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            RoomsAvailables.AllRoomsAvailables = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(RoomsAvailables.Count, TestList.Count);
        }
    }
}