<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="LINQPractice._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Queries on LINQ</p>
        <p>
            <asp:DropDownList ID="ddlOption" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Please select</asp:ListItem>
                <asp:ListItem Value="Student List"></asp:ListItem>
                <asp:ListItem Value="Teacher List"></asp:ListItem>
                <asp:ListItem Value="Course List"></asp:ListItem>
            </asp:DropDownList>
        </p>
        <asp:GridView ID="gvDisplay" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="414px">
            <asp:ListItem>Please select</asp:ListItem>
            <asp:ListItem>Students who are under 18 years of age (in order of age)</asp:ListItem>
            <asp:ListItem>Students who are teenagers (alphabetical order by last name)</asp:ListItem>
            <asp:ListItem>Students who scored 80 or more in their last test (order by score descending)</asp:ListItem>
            <asp:ListItem>Students who scored over 320 marks in total(across all their tests)</asp:ListItem>
            <asp:ListItem>Students who scored at least 60 in all of their tests </asp:ListItem>
            <asp:ListItem>Students grouped by first letter of their last name</asp:ListItem>
            <asp:ListItem>Average score of each test</asp:ListItem>
            <asp:ListItem>Students who are also teachers</asp:ListItem>
            <asp:ListItem>Courses of a duration of 15 weeks</asp:ListItem>
            <asp:ListItem>Courses held in the Winter semester(order by duration) </asp:ListItem>
            <asp:ListItem>Courses grouped by semester</asp:ListItem>
        </asp:ListBox>
        <br />
        <asp:ListBox ID="lbResult" runat="server" SelectionMode="Multiple" Width="412px"></asp:ListBox>
    </form>
</body>
</html>
