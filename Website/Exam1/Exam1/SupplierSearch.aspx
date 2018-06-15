<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupplierSearch.aspx.cs" Inherits="Exam1.SupplierSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Supplier Search:</h1>
            <br />
            <h4>First Search Option:</h4>
            <p>
                <asp:DropDownList ID="ddlCompanyName" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataSourceID="ODSCompanyName" DataTextField="CompanyName" DataValueField="SupplierID" OnSelectedIndexChanged="ddlCompanyName_SelectedIndexChanged" >
                <asp:ListItem Text="Please select a company" Value="" />
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ODSCompanyName" runat="server" SelectMethod="getSupplierName" TypeName="Exam1.BAL.BAL_Northwind"></asp:ObjectDataSource>
            </p>
        </div>
        <h4>Second Search Option:</h4>
        <p>
            <asp:DropDownList ID="ddlCity" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataSourceID="ODSCity"   >
           <asp:ListItem Text="Please select a city" Value="" />
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ODSCity" runat="server" SelectMethod="getSupplierCity" TypeName="Exam1.BAL.BAL_Northwind"></asp:ObjectDataSource>
        </p>
        <div>
            Resulting list:</div>
        <asp:GridView ID="gvSuppliers" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ODSSuppliersByCity" ForeColor="#333333" GridLines="None" DataKeyNames="SupplierID" OnSelectedIndexChanged="gvSuppliers_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="CompanyName" HeaderText="Company Name" SortExpression="CompanyName" />
                <asp:BoundField DataField="ContactName" HeaderText="Contact Name" SortExpression="ContactName" />
                <asp:BoundField DataField="ContactTitle" HeaderText="Contact Title" SortExpression="ContactTitle" />
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="Region" HeaderText="Region" SortExpression="Region" />
                <asp:BoundField DataField="PostalCode" HeaderText="Postal Code" SortExpression="PostalCode" />
                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                <asp:BoundField DataField="Fax" HeaderText="Fax" SortExpression="Fax" />
                <asp:BoundField DataField="HomePage" HeaderText="HomePage" SortExpression="HomePage" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ODSSuppliersByCity" runat="server" SelectMethod="getSupplierByCity" TypeName="Exam1.BAL.BAL_Northwind">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlCity" DefaultValue="null" Name="city" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </form>
</body>
</html>
