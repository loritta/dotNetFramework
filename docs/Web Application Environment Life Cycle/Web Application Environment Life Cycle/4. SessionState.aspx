<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4. SessionState.aspx.cs" Inherits="Web_Application_Environment_Life_Cycle.SessionState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            My Count&nbsp;
            <asp:TextBox ID="txtCount" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnIncrement" runat="server" OnClick="Button1_Click" Text="Increment" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>

</html>
