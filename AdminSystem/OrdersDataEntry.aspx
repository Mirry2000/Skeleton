<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

 p.MsoNormal
	{margin-top:0in;
	margin-right:0in;
	margin-bottom:10.0pt;
	margin-left:0in;
	line-height:115%;
	font-size:11.0pt;
	font-family:"Calibri",sans-serif;
	}
    </style>
</head>
<body>
    This is the order entry page
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderId" runat="server" Text="Order Number" width="108px"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtOrderId" runat="server" Width="129px"></asp:TextBox>
        <br />
        <asp:Label ID="lblUserId" runat="server" Text="User Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtUserId" runat="server" style="margin-top: 0px" width="128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblOrderline" runat="server" Text="Resturant Line" width="102px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtOrderLine" runat="server" width="128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblOrderDate" runat="server" Text="Date Added" width="107px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtOrderDate" runat="server" width="128px"></asp:TextBox>
        <br />
        <asp:Label ID="lblOrderContent" runat="server" Text="Order Information" width="120px"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtOrderContent" runat="server" width="128px"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkOrderStatus" runat="server" Text="Active" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        <br />
    </form>
</body>
</html>
