<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Supplier Search.aspx.cs" Inherits="ADONET_Demo.Supplier_Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: medium;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 133px;
        }
        .auto-style4 {
            width: 300px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">Supplier ID</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtInput" runat="server" TextMode="Number" Width="250px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" Width="137px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:ListBox ID="lbSuppliers" runat="server" Width="250px"></asp:ListBox>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlSuppliers" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSuppliers_SelectedIndexChanged">
                        </asp:DropDownList>
&nbsp; </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:DetailsView ID="dvSupplier" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="50px" Width="299px">
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
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <asp:Label ID="lblConnection" runat="server" CssClass="auto-style1" Font-Bold="True" ForeColor="#006600"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
