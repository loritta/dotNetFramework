<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Default.Master" AutoEventWireup="true" CodeBehind="NewCustomer.aspx.cs" Inherits="Assignment2.Pages.NewCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<style type="text/css">
		.auto-style2 {
			width: 193px;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<h1>New Customer</h1>
	<h4>Fill the following fields to add a new customer</h4>
	<table class="auto-style1">
		<tr>
			<td class="auto-style2">First Name </td>
			<td>
				<asp:TextBox ID="tbFName" runat="server"></asp:TextBox>
				<asp:RequiredFieldValidator ID="rfvFName" runat="server" ErrorMessage="Required" ForeColor="Red">Required</asp:RequiredFieldValidator>
			</td>
		</tr>
		<tr>
			<td class="auto-style2">Last Name</td>
			<td>
				<asp:TextBox ID="tbLName" runat="server"></asp:TextBox>
				<asp:RequiredFieldValidator ID="rfvLName" runat="server" ErrorMessage="Required" ForeColor="Red">Required</asp:RequiredFieldValidator>
			</td>
		</tr>
		<tr>
			<td class="auto-style2">Address</td>
			<td>
				<asp:TextBox ID="tbAddress" runat="server"></asp:TextBox>
				<asp:RequiredFieldValidator ID="rfvAddress" runat="server" ErrorMessage="Required" ForeColor="Red">Required</asp:RequiredFieldValidator>
			</td>
		</tr>
		<tr>
			<td class="auto-style2">
				<p>
&nbsp;Phone number
				</p>
			</td>
			<td>
				<asp:TextBox ID="tbPhoneNumber" runat="server" TextMode="Phone"></asp:TextBox>
				<asp:RequiredFieldValidator ID="rfvPhoneNumber" runat="server" ErrorMessage="Required" ForeColor="Red">Required</asp:RequiredFieldValidator>
			</td>
		</tr>
	</table>
	<p>
		<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add the Customer" />
	</p>
	<p>
		&nbsp;</p>
	<p>
		&nbsp;</p>
</asp:Content>
