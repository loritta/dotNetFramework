<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="9. Navigation.aspx.cs" Inherits="Web_Application_Environment_Life_Cycle.Navigation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ASP Hyperlink control<br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/9.1 Navigation_Target.aspx">Hyperlink Internal</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="http://www.google.com">External Link</asp:HyperLink>
            <br />
            <br />
            <strong>Response.Redirect Demo</strong><br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Redirect Internal" Width="200px" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Redirect External " Width="200px" />
            <br />
            <br />
            <strong>Server.Transfer Demo</strong><br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Transfer Internal" Width="200px" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Tranfer External" Width="200px" />
            <br />
            <br />
            User Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Trasfer (Target 2)" Width="200px" />
        </div>
    </form>
</body>
</html>
