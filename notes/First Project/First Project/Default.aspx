<%@ Page Language="C#" AutoEventWireup="true" 
     Title ="Hello World" Trace="true" CodeBehind="Default.aspx.cs" Inherits="First_Project.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name:
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" Width="100px" />
            <button>Test</button>
            <br />
            <br />
            <asp:Label ID="lblName" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
