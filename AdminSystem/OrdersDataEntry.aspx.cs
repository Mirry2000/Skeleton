using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        ////create a new insatnce of clsOrderId
        clsOrder AnOrder = new clsOrder();
        //capture the orders id
        AnOrder.OrderContent = txtOrderContent.Text;
        Session["AnOrder"] = AnOrder;
        //navigate to the viewer page
        Response.Redirect("OrdersViewer.aspx");
    }



    //create for all


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the order class
        clsOrder AnOrder = new clsOrder();
        //variable to store the primry key
        Int32 OrderId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderId = Convert.ToInt32(txtOrderId.Text);
        //find the record
        Found = AnOrder.Find(OrderId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtUserId.Text = AnOrder.UserId.ToString();
            txtOrderLine.Text = AnOrder.OrderLine.ToString();
            txtOrderContent.Text = AnOrder.OrderContent;
            txtOrderDate.Text = AnOrder.OrderDate.ToString();



        }
    }
}