<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewProduc.aspx.cs" Inherits="Exam1.NewProduc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 147px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>New Product</h1>
        <h4>
            <br />
            <br />
            Fields to add</h4>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Product Name:</td>
                <td>
                    <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="tbName" Display="Dynamic" ErrorMessage="Name is required" ForeColor="Red">Required</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">QuantityPerUnit</td>
                <td>
                    <asp:TextBox ID="tbQuantity" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvQuantity" runat="server" ControlToValidate="tbName" Display="Dynamic" ErrorMessage="Quantity is required" ForeColor="Red">Required</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">UnitPrice:</td>
                <td>
                    <asp:TextBox ID="tbPricePerUnit" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">UnitsInStock:</td>
                <td>
                    <asp:TextBox ID="tbUnitsInStock" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">UnitsOnOrder:</td>
                <td>
                    <asp:TextBox ID="tbUnitOnOrder" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">OrderLevel:</td>
                <td>
                    <asp:TextBox ID="tbOrderLevel" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Discontinued:</td>
                <td>
                    <asp:CheckBox ID="cbDiscont" runat="server" />
                </td>
            </tr>
        </table>
        <h4>Available categories</h4>
        <p>
            <asp:DropDownList ID="ddlSQLDSCategories" runat="server" AppendDataBoundItems="True" DataSourceID="SDSCategories" DataTextField="CategoryName" DataValueField="CategoryID" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                 <asp:ListItem Text="Please select a category" Value="" />
            </asp:DropDownList>
            <asp:SqlDataSource ID="SDSCategories" runat="server" ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString %>" SelectCommand="SELECT [CategoryID], [CategoryName] FROM [Categories] ORDER BY [CategoryName]"></asp:SqlDataSource>
        </p>
        <p>
            <asp:Button ID="btnAddNew" runat="server" Text="Add New Product" OnClick="btnAddNew_Click" />
        </p>
        <asp:Label ID="lblResult" runat="server"></asp:Label>
        <br />
        <asp:HyperLink ID="hlSupplierSearch" runat="server" NavigateUrl="~/SupplierSearch.aspx" Visible="False">Supplier Search</asp:HyperLink>
    </form>
</body>
</html>
