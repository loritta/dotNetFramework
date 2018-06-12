<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LINQ_Exercises.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlLists" runat="server" AutoPostBack="True" Height="39px" OnSelectedIndexChanged="ddlLists_SelectedIndexChanged" Width="348px">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>Student List</asp:ListItem>
                <asp:ListItem>Teacher List</asp:ListItem>
                <asp:ListItem>Course List</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>Students who are under 18 years of age (in order of age)</asp:ListItem>
            </asp:ListBox>
            <br />
            <asp:GridView ID="gvDisplay" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
