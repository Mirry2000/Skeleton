using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new insatnce of the class
        clsOrder AnOrder = new clsOrder();
        //get data from the session object
        AnOrder = (clsOrder) Session["AnOrder"];
        //display the  order content on page
        Response.Write(AnOrder.OrderContent);
    }


}