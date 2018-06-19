<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Default.Master" AutoEventWireup="true" CodeBehind="RentMedia.aspx.cs" Inherits="Assignment2.Pages.RentMedia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<style type="text/css">
		.auto-style2 {
			width: 685px;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<h1>Rent Media </h1>
	<h4>Search by title</h4>
	<table class="auto-style1">
		<tr>
			<td class="auto-style2">
				<asp:TextBox ID="tbSearchTitle" runat="server" AutoPostBack="True" OnTextChanged="tbSearch_TextChanged" Width="625px"></asp:TextBox>
			</td>
		</tr>
	</table>
	<h4>Search by type</h4>
	<table class="auto-style1">
		<tr>
			<td class="auto-style2">
				<asp:TextBox ID="tbSearchType" runat="server" AutoPostBack="True" OnTextChanged="tbSearchType_TextChanged" Width="625px"></asp:TextBox>
			</td>
		</tr>
	</table>
	<h4>Result</h4>
	<asp:CheckBoxList ID="cblResult" runat="server" DataTextField="Title" DataValueField="ID">
	</asp:CheckBoxList>
	<asp:Label ID="lblResult" runat="server" Visible="False"></asp:Label>
	<br />
	<asp:Button ID="btnRentMedia" runat="server" OnClick="btnRentMedia_Click" Text="Rent Now" />
	<br />
</asp:Content>
