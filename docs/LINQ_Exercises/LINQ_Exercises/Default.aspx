<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LINQ_Exercises.Default" MaintainScrollPositionOnPostback ="true" %>

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
            <asp:GridView ID="gvDisplay" runat="server">
            </asp:GridView>
            <br />
            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Height="204px">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>Students who are under 18 years of age (in order of age)</asp:ListItem>
                <asp:ListItem>Students who are teenagers (alphabetical order by last name)</asp:ListItem>
                <asp:ListItem>Students who scored 80 or more in their last test (order by score descending)</asp:ListItem>
                <asp:ListItem>Students who scored over 320 marks in total (across all their tests)</asp:ListItem>
                <asp:ListItem>Students who scored at least 60 in all of their tests</asp:ListItem>
                <asp:ListItem>Students grouped by first letter of their last name</asp:ListItem>
                <asp:ListItem>Average score of each test</asp:ListItem>
                <asp:ListItem>Students who are also teachers</asp:ListItem>
                <asp:ListItem>Courses of a duration of 15 weeks</asp:ListItem>
                <asp:ListItem>Courses held in the Winter semester (order by duration)</asp:ListItem>
                <asp:ListItem>Courses grouped by semester </asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            <asp:TextBox ID="result" runat="server" Height="151px" ReadOnly="True" TextMode="MultiLine" Width="464px"></asp:TextBox>
            <br />
            <br />
&nbsp;<br />
            <br />
        </div>
    </form>
</body>
</html>
