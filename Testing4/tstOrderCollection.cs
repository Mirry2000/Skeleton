using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Test_Framework
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instacne of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderStatus = true;
            TestItem.OrderId = 1;
            TestItem.UserId = 10;
            TestItem.OrderLine = 100;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderContent = "Ramen";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        /*[TestMethod] //removed test
        public void CountPropertyOK()
        {
            //create an instance of the class we cant to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            AllOrders.Count = SomeCount;
            Assert.AreEqual(AllOrders.Count, SomeCount);
        }*/

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set its properties of the test object
            TestOrder.OrderStatus = true;
            TestOrder.OrderId = 1;
            TestOrder.UserId = 10;
            TestOrder.OrderLine = 100;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.OrderContent = "Ramen";
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderStatus = true;
            TestItem.OrderId = 1;
            TestItem.UserId = 10;
            TestItem.OrderLine = 100;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderContent = "Ramen";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        /*[TestMethod] // removed test
        public void TwoRecordsPresent()
        {
            //create an instacne of the class we want to create 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see if that two values are the same
            Assert.AreEqual(AllOrders.Count, 2);
        }*/ 
    }

    
  
}
