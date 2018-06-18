<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Default.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Assignment2.Pages.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<asp:ImageButton ID="btnimgCustomers" runat="server" ImageUrl="~/Images/customers.jpg" PostBackUrl="~/Pages/Customers.aspx" Width="1000px" />
	<p>
		<asp:ImageButton ID="btnimgMovie" runat="server" ImageUrl="~/Images/movie_reel.jpg" PostBackUrl="~/Pages/RentMedia.aspx" Width="1000px" />
	</p>
	<asp:ImageButton ID="btnimgAddCustomer" runat="server" ImageUrl="~/Images/new_customer.jpg" PostBackUrl="~/Pages/NewCustomer.aspx" Width="1000px" />
	<br />
	<br />
	<asp:ImageButton ID="btnimgNewMovie" runat="server" ImageUrl="~/Images/add_movie.png" PostBackUrl="~/Pages/NewMedia.aspx" Width="900px" />
	<br />
	<br />
</asp:Content>
