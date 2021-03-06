using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time page is displayed 
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }
    
     }

    private void DisplayOrders()
    {
        //create and instance of the the order collection 
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to list of orders in the collection 
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        //set the data field to display
        lstOrderList.DataTextField = "OrderContent";
        //bind the data to the list
        lstOrderList.DataBind();


    }
}