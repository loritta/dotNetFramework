<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Orders Search.aspx.cs" Inherits="ADONET_Demo.Orders_Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 314px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span class="auto-style1">Order Search</span><br class="auto-style1" />
            <br />
            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">Order ID</td>
                    <td>
                        <asp:TextBox ID="txtOrderID" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:DropDownList ID="ddlOptions" runat="server" Width="200px">
                            <asp:ListItem Value="Customers">Customer Details</asp:ListItem>
                            <asp:ListItem Value="Shippers">Shipper Details</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" Width="200px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:DetailsView ID="dvOrder" runat="server" Height="50px" Width="200px">
                        </asp:DetailsView>
                    </td>
                    <td>
                        <asp:ListBox ID="lbOption" runat="server" Width="200px"></asp:ListBox>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
