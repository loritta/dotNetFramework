<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PriceQuotation.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
            <h1>Price Quotation</h1>
            <h4>Sales price&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:TextBox ID="txtPrice" runat="server" Width="251px"></asp:TextBox></h4><br />
            <h4>Discount percent&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                <asp:TextBox ID="txtPercent" runat="server" Width="251px"></asp:TextBox></h4>
            <h4>Discount amount&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:Label ID="lblAmount" runat="server" Text=".."></asp:Label></h4><br />
            <h4>Total price&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:Label ID="lblTotal" runat="server" Text=".."></asp:Label> </h4><br />
            
        </div>
        <asp:Button ID="btnCalc" runat="server" Text="Calculate" OnClick="btnCalc_Click" Width="147px" />
    </form>
</body>
</html>
