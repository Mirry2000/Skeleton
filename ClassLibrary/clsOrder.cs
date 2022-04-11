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




        /*public bool Find(int OrderId)
        {
            //set the private data members to the test data value
            mOrderId = 1;
            mUserId = 10;
            mOrderLine = 100;
            mOrderContent = "Ramen";
            mOrderDate = Convert.ToDateTime("21/03/2022");
            mOrderStatus = true;
            //always return true
            return true;

        }*/


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

        public string Valid(string userId, string orderLine, string orderDate, string orderContent)
        {
            //create a string variable to store the error
            String Error = "";

            //create a temporary variable to store date values
            DateTime DateTemp;

            //if the UserId is blank
            if (userId.Length == 0)
            {
                //record the error
                Error = Error + "The User Id cannot be blank : ";
            }

            //if the user id is greater than 100
            if (userId.Length > 2)
            {
                //record the error
                Error = Error + "User Id must be less than 100 : ";
            }

            //orderline
            // if the orderline is blank
             if (orderLine.Length == 0)
            {
                //record the error
                Error = Error + "The order line number cannot be blank :";
            }


            // if the order line is greater than 1000
             if (orderLine.Length > 50)
             {
                 //record the error
                 Error = Error + "The order line must be less than 1000";
             }

            //is the content blank
            if (orderContent.Length == 0)
            {
                //record the error
                Error = Error + "The content may not be blank : ";
            }
            //if the content is too long
            if (orderContent.Length > 50)
            {
                //record the error
                Error = Error + "The content must be less than 50 characters : ";
            }

            try
            {
                //copy the Order date value to the DateTemp variable
                DateTemp = Convert.ToDateTime(orderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past: ";
                }

                //check to see if date is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error 
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            
            //return any error messages
            return Error;       

        }
    }

}