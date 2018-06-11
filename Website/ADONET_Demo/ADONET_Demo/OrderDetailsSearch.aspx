<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderDetailsSearch.aspx.cs" Inherits="ADONET_Demo.OrderDetailsSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 130px;
        }
        .auto-style3 {
            width: 223px;
        }
        .auto-style4 {
            width: 130px;
            height: 26px;
        }
        .auto-style5 {
            width: 223px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            height: 26px;
            width: 162px;
        }
        .auto-style8 {
            width: 162px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Search for Order Details:</h1>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">Order ID</td>
                <td class="auto-style5">
                    <asp:TextBox ID="tbOrderID" runat="server" TextMode="Number"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:DropDownList ID="ddlCustomerShipper" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCustomerShipper_SelectedIndexChanged">
                        <asp:ListItem Value="Customer"></asp:ListItem>
                        <asp:ListItem Value="Shipper"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style6">
                    <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Order details</td>
                <td class="auto-style3">
                    <asp:DetailsView ID="dvOrder" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="50px" Width="125px">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
                        <EditRowStyle BackColor="#999999" />
                        <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    </asp:DetailsView>
                </td>
                <td class="auto-style8">Customer/Shipper details:</td>
                <td>
                    <asp:ListBox ID="lbxCustomerShipper" runat="server"></asp:ListBox>
                </td>
            </tr>
        </table>
        <asp:Label ID="lblConnection" runat="server"></asp:Label>
    </form>
</body>
</html>
