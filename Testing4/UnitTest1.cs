using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some test data to pass to the method
        string UserId = "10";
        string OrderLine = "100";
        string OrderDate = DateTime.Now.Date.ToString();
        string OrderContent = "Ramen";



        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]

        public void OrderStatusOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.OrderStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderStatus, TestData);
        }

        [TestMethod]
        public void OrderDateOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void OrderIdOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

        [TestMethod]
        public void UserIdOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.UserId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.UserId, TestData);
        }

        [TestMethod]
        public void OrderContentOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            string TestData = "Ichiraku Ramen";
            //assign the data to the property
            AnOrder.OrderContent = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderContent, TestData);
        }

        [TestMethod]
        public void OrderLineOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderLine = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderLine, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the search[TestMethod]
            Boolean Found = false;
            //create some test data to use with method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the address no
            if (AnOrder.OrderId != 1)
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order date 
            if (AnOrder.OrderDate != Convert.ToDateTime("21/03/2022"))
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestOrderContentFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the property
            if (AnOrder.OrderContent != "Ramen")
            {
                OK = false;
            }
            //test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderStatusFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the property
            if (AnOrder.OrderStatus != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUserIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the property
            if (AnOrder.UserId != 10)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderLineFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the property
            if (AnOrder.OrderLine != 100)
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
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void UserIdMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string UserId = "";//should trigger error
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void UserIdMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string UserId = "10";//should be ok
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void UserIdMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string UserId = "11";//should be ok
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void UserIdMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string UserId = "98";//should be ok
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void UserIdMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string UserId = "99";//should be ok
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void UserIdMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string UserId = "56";//should be ok
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void UserIdMaxplusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string UserId = "100";//should trigger error
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void UserIdExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string UserId = "";
            UserId = UserId.PadRight(300, '1');//should trigger error
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }





        [TestMethod]

        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]

        public void OrderDateMinlessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]

        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]

        public void OrderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]

        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void OrderDateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the OrderDate to non date value
            string OrderDate = "This is not a date";
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]

        public void OrderlineMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string OrderLine = "";//should trigger error
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void OrderlineMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string OrderLine = "100";//should pass 
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void OrderlineMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string OrderLine = "101";//should pass
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void OrderlineMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string OrderLine = "998";//should pass
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void OrderlineMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string OrderLine = "999";//should  pass
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void OrderlineMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string OrderLine = "550";//should pass
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void OrderlineMaxPlusOne() //ISEWEEWF
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string OrderLine = "";//should trigger error
           // OrderLine = OrderLine.PadRight(3, '1');
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /*[TestMethod]

        public void OrderlineExtremeMax() //wqdqdbhjbqwhjdbhjqwb
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string OrderLine = "";
            OrderLine = OrderLine.PadRight(100, '1');//should trigger error
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }*/

        [TestMethod]
        public void OrderContentMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string OrderContent = "";
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderContentMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderContent = "a";
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderContentMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderContent = "aa";
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderContentMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderContent = "";
            OrderContent = OrderContent.PadRight(49, 'm');
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void OrderContentMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderContent = "";
            OrderContent = OrderContent.PadRight(50, 'm');
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void OrderContentMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string OrderContent = "";
            OrderContent = OrderContent.PadRight(51, 'm');
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void OrderContentMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string OrderContent = "";
            OrderContent = OrderContent.PadRight(25, 'm');
            //invoke the method
            Error = AnOrder.Valid(UserId, OrderLine, OrderDate, OrderContent);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

    }
}