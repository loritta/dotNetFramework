<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Default.Master" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="Assignment2.Pages.Customers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<h1>Available customers</h1>
	<h4>Customers</h4>
	<p>
		<asp:GridView ID="gvCustomers" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ID" DataSourceID="ODSCustomers" ForeColor="#333333" GridLines="None">
			<AlternatingRowStyle BackColor="White" />
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
				<asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
				<asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
				<asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
				<asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" SortExpression="PhoneNumber" />
			</Columns>
			<EditRowStyle BackColor="#2461BF" />
			<FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
			<HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
			<PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
			<RowStyle BackColor="#EFF3FB" />
			<SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
			<SortedAscendingCellStyle BackColor="#F5F7FB" />
			<SortedAscendingHeaderStyle BackColor="#6D95E1" />
			<SortedDescendingCellStyle BackColor="#E9EBEF" />
			<SortedDescendingHeaderStyle BackColor="#4870BE" />
		</asp:GridView>
		<asp:ObjectDataSource ID="ODSCustomers" runat="server" SelectMethod="GetAllCustomers" TypeName="Assignment2.Models.VideoRentalStoreRepository"></asp:ObjectDataSource>
	</p>
	<p>
		&nbsp;</p>
	<h4>Customer details</h4>
	<p>
		<asp:DetailsView ID="dvCustomer" runat="server" AutoGenerateRows="False" CellPadding="4" DataSourceID="ODSCustomerByID" ForeColor="#333333" GridLines="None" Height="50px" Width="125px">
			<AlternatingRowStyle BackColor="White" />
			<CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
			<EditRowStyle BackColor="#2461BF" />
			<FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
			<Fields>
				<asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
				<asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
				<asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
				<asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
				<asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" SortExpression="PhoneNumber" />
			</Fields>
			<FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
			<HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
			<PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
			<RowStyle BackColor="#EFF3FB" />
		</asp:DetailsView>
		<asp:ObjectDataSource ID="ODSCustomerByID" runat="server" SelectMethod="GetCustomerbyID" TypeName="Assignment2.Models.VideoRentalStoreRepository" UpdateMethod="UpdateCustomer">
			<SelectParameters>
				<asp:ControlParameter ControlID="gvCustomers" DefaultValue="0" Name="ID" PropertyName="SelectedValue" Type="Int32" />
			</SelectParameters>
			<UpdateParameters>
				<asp:Parameter Name="originalCustomer" Type="Object" />
				<asp:Parameter Name="customer" Type="Object" />
			</UpdateParameters>
		</asp:ObjectDataSource>
	</p>
	<p>
		<asp:Button ID="btnRentMedia" runat="server" OnClick="btnRentMedia_Click" Text="Rent Media for this Customer" />
	</p>
</asp:Content>
