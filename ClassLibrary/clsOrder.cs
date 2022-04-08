using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for order id property
        private Int32 mOrderId;
        public Int32 OrderId
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                //this line of code allows data into the property
                mOrderId = value;
            }
        }

        //private data member for OrderStatus
        private Boolean mOrderStatus;
        //public property for OrderStatus
        public bool OrderStatus
        {
            get
            {
                //return the private data 
                return mOrderStatus;
            }
            set
            {
                mOrderStatus = value;
            }


        }
        //OrderDate private number variable 
        private DateTime mOrderDate;
        //OrderDate public property
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }

        //private data member for User id
        private Int32 mUserId;
        public int UserId
        {
            get
            {
                //return the private data
                return mUserId;
            }
            set
            {
                mUserId = value;
            }
        }

        //private data member for content
        private string mOrderContent;
        public string OrderContent
        {
            get
            {
                return mOrderContent;
            }
            set
            {
                mOrderContent = value;
            }
        }

        //privater member for OrderLine property 
        private Int32 mOrderLine;
        //public property for the order line
        public int OrderLine
        {
            get
            {
                //return the private data
                return mOrderLine;
            }
            set
            {    //set the value of the private member
                mOrderLine = value;
            }

            
        }
        
        public bool Find(int OrderId)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mOrderLine = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLine"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mOrderStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderStatus"]);
                mOrderContent = Convert.ToString(DB.DataTable.Rows[0]["OrderContent"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found 
            else
            {
                //return false indicating a problem
                return false;
            }

        }     
    }

  
}