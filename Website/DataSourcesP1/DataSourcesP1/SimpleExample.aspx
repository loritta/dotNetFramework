<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleExample.aspx.cs" Inherits="DataSourcesP1.SimpleExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/main.css" rel="stylesheet" />
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <strong>Bulleted List Binding<br />
            <asp:BulletedList ID="blBinding" runat="server" DataTextField="Name" DataValueField="URL" DisplayMode="HyperLink">
            </asp:BulletedList>
            </strong>
        </div>
        <p>
            &nbsp;</p>
        <section>
            <strong>
            <br />
            Drop Down List Binding<br />
            </strong>
            <br />
            <asp:DropDownList ID="ddlQuestions" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlQuestions_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblOptions" runat="server" Text="..."></asp:Label>
            <br />
            <asp:Label ID="lblDeopDown" runat="server" Text="..."></asp:Label>
            <br />
        </section>
        <section>
            <strong>List Box Binding</strong><br />
            <br />
            <asp:ListBox ID="lbBinding" runat="server" AutoPostBack="True" DataTextField="Name" DataValueField="ID" OnSelectedIndexChanged="lbBinding_SelectedIndexChanged"></asp:ListBox>
            <br />
            <br />
            <asp:Label ID="lblListBox" runat="server" Text="..."></asp:Label>
            <br />
        </section>
    </form>

</body>
</html>
