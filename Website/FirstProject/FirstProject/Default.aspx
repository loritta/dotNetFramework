<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FirstProject.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            &nbsp;&nbsp;&nbsp;
            <asp:Label runat="server" Text="Name:  "></asp:Label>
            &nbsp;
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="105px" OnClick="btnSubmit_Click" />
            <br />
            <br />
            <asp:Label id="lblName" runat="server" title="lblName" />
            
        </div>
    </form>
</body>
</html>
