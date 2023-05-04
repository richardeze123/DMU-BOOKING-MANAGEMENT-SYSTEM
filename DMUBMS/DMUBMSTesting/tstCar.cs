using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DMUBMSClasses;

namespace DMUBMSTesting
{
    [TestClass]
    public class tstCar
    {
        //good test data
        //create some test data to pass to the method
        string Model = "BMW";
        string Brand = "Test Data";
        string Price = "Test";
       

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            //
            // TODO: Add test logic here
            //
        }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCar AnCar = new clsCar();
            //test to see that it exists
            Assert.IsNotNull(AnCar);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCar AnCar = new clsCar();
            //create some test data to assign to the property
            string TestData = "";
            //assign the data to the property
            AnCar.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCar.Available, TestData);
        }

        [TestMethod]
        public void RegNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCar AnCar = new clsCar();
            //create some test data to assign to the property
            string TestData = "";
            //assign the data to the property
            AnCar.RegNo = TestData; 
            //test to see that the two values are the same
            Assert.AreEqual(AnCar.RegNo, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsCar AnCar = new clsCar();
            //create some test data to assign to the property
            string TestData = "";
            //assign the data to the property
            AnCar.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCar.Price, TestData);
        }
        [TestMethod]
        public void ModelPropertyOK()
        {
            //create an instance of the class we want to create
            clsCar AnCar = new clsCar();
            //create some test data to assign to the property
            string TestData = "";
            //assign the data to the property
            AnCar.Model = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCar.Model, TestData);
        }
        [TestMethod]
        public void BrandProperty()
        {
            //create an instance of the class we want to create
            clsCar AnCar = new clsCar();
            //create some test data to assign to the property
            string TestData = "";
            //assign the data to the property
            AnCar.Brand = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCar.Brand, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCar AnCar = new clsCar();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string RegNo = "";
            //invoke the method
            Found = AnCar.Find(RegNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestHotelNoFound()
        {
            //create an instance of the class we want to create
            clsCar AnCar = new clsCar();
            //boolean variable to store the result of the search
            string Found = "";
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string RegNo = "";
            //invoke the method
            //check the Hotel no
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void BrandMin()
        {
            //create an instance of the class we want to create
            clsCar AnCar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Brand = "BMW"; //this should be ok
            //invoke the method
            Error = AnCar.Valid(Model, Brand, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelExtremeMax()
        {
            //create an instance of the class we want to create
            clsCar AnCar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Model = "";
            Model = Model.PadRight(50, '1'); //this should fail
            //invoke the method
            Error = AnCar.Valid(Brand, Model, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ModelMin()
        {
            //create an instance of the class we want to create
            clsCar AnCar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Model = "BMW"; //this should be ok
            //invoke the method
            Error = AnCar.Valid(Model, Brand, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandExtremeMax()
        {
            //create an instance of the class we want to create
            clsCar AnCar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Brand = "";
            Model = Brand.PadRight(50, '1'); //this should fail
            //invoke the method
            Error = AnCar.Valid(Brand, Model, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsCar AnCar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "";
            Model = Price.PadRight(50, '1'); //this should fail
            //invoke the method
            Error = AnCar.Valid(Brand, Model, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCar AnCar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "";
            Model = Price.PadRight(50); //this should fail
            //invoke the method
            Error = AnCar.Valid(Brand, Model, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void ModellessOne()
        {
            //create an instance of the class we want to create
            clsCar AnCar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Model = "BMW"; //this should be ok
            //invoke the method
            Error = AnCar.Valid(Model, Brand, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsCar AnCar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "BMW"; //this should be ok
            //invoke the method
            Error = AnCar.Valid(Model, Brand, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void BrandMinLessOne()
        {
            //create an instance of the class we want to create
            clsCar AnCar = new clsCar();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Brand = "";
            //invoke the method
            Error = AnCar.Valid(Brand, Model, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }














































    }

}


