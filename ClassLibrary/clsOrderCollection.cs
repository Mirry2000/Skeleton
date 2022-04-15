using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();

        //public property for the order list 
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //later
            }
        }
            

        public clsOrder ThisOrder { get; set; }



       /* public clsOrderCollection()
        {
            //create the items of the test data 
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderStatus = true;
            TestItem.OrderId = 1;
            TestItem.UserId = 10;
            TestItem.OrderLine = 100;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderContent = "Ramen";
            //add the item to the test list
            mOrderList.Add(TestItem);
            //re-initialise the object for some new data
            TestItem = new clsOrder();
            //set its properties
            TestItem.OrderStatus = true;
            TestItem.OrderId = 2;
            TestItem.UserId = 21;
            TestItem.OrderLine = 200;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderContent = "Rice";
            mOrderList.Add(TestItem);
        }*/

        public clsOrderCollection()
        {
            //var for the index 
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create blank order 
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.OrderStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderStatus"]);
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.UserId = Convert.ToInt32(DB.DataTable.Rows[Index]["UserId"]);
                AnOrder.OrderLine = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderLine"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.OrderContent = Convert.ToString(DB.DataTable.Rows[Index]["OrderContent"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }
    }


    
}