<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Default.Master" AutoEventWireup="true" CodeBehind="NewMedia.aspx.cs" Inherits="Assignment2.Pages.NewMedia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<style type="text/css">
		.auto-style2 {
			height: 23px;
		}
		.auto-style3 {
			width: 215px;
		}
		.auto-style4 {
			height: 23px;
			width: 215px;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<h1>NewMedia</h1>
	<h4>Fill the following fields to add a new media</h4>
	<table class="auto-style1">
		<tr>
			<td class="auto-style3">Title&nbsp; </td>
			<td>
			<asp:TextBox ID="tbTitle" runat="server"></asp:TextBox>
			<asp:RequiredFieldValidator ID="rfvFTitle" runat="server" ControlToValidate="tbTitle" ErrorMessage="Required" ForeColor="Red">Required</asp:RequiredFieldValidator>
			</td>
		</tr>
		<tr>
			<td class="auto-style4">Type (Movies, TV Show,. Etc.)</td>
			<td class="auto-style2">
			<asp:TextBox ID="tbType" runat="server"></asp:TextBox>
			<asp:RequiredFieldValidator ID="rfvType" runat="server" ControlToValidate="tbType" ErrorMessage="Required" ForeColor="Red">Required</asp:RequiredFieldValidator>
			</td>
		</tr>
		<tr>
			<td class="auto-style3">Production Year</td>
			<td>
			<asp:TextBox ID="tbYear" runat="server" TextMode="Date"></asp:TextBox>
			<asp:RequiredFieldValidator ID="rfvYear" runat="server" ControlToValidate="tbYear" ErrorMessage="Required" ForeColor="Red">Required</asp:RequiredFieldValidator>
			</td>
		</tr>
	</table>
	<br />
	<asp:Button ID="btnAddMedia" runat="server" OnClick="Button1_Click" Text="Add the Media" />
</asp:Content>
