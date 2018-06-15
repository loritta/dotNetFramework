<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2.3. ViewState.aspx.cs" Inherits="Web_Application_Environment_Life_Cycle.ViewState" %>

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
        &nbsp;<asp:Button ID="btnIncrement0" runat="server" OnClick="btnIncrement0_Click" Text="Increment Text Box" />
            <br />
            <br />
            HTML Control&nbsp;
            <input id="Text1" type="text" runat="server" /><asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Post Back Dummy" />
        </div>
    </form>
</body>
</html>
