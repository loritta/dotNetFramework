<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="userInformation.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 225px;
        }
        .auto-style3 {
            font-size: large;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3" colspan="2">
                        <h1>User Information:</h1>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Name:</td>
                    <td>
                        <asp:TextBox ID="tbName" runat="server" Width="148px" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Date of birth:</td>
                    <td>
                        <asp:Calendar ID="calBirth" runat="server"></asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">E-mail:</td>
                    <td>
                        <asp:TextBox ID="tbEmail" runat="server" Width="149px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Province</td>
                    <td>
                        <asp:DropDownList ID="ddlProvince" runat="server" Width="160px" AutoPostBack="True" OnSelectedIndexChanged="ddlProvince_SelectedIndexChanged">
                            <asp:ListItem Selected="True">Please select</asp:ListItem>
                            <asp:ListItem>Quebec</asp:ListItem>
                            <asp:ListItem>Ontario</asp:ListItem>
                            <asp:ListItem>British Columbia</asp:ListItem>
                            <asp:ListItem>Alberta</asp:ListItem>
                            <asp:ListItem>New Brunswick</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">City</td>
                    <td>
                        <asp:DropDownList ID="ddlCity" runat="server" Width="160px">
                            <asp:ListItem>Please select</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" Width="178px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" >
                        <asp:Label ID="lblPrint" runat="server" Font-Bold="True" ForeColor="Maroon" Text="..."></asp:Label>
                    </td>
                    <td>
                       
                    </td>
                </tr>
            </table>
        </div>
        <asp:ListBox ID="lbRecord" runat="server" Width="736px"></asp:ListBox>
        <input type="hidden" id="hidVal" name="hidVal" runat="server" value="0" />
    </form>
</body>
</html>
