<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="userInformation.Default" ErrorPage="Error.html"%>

<%@ Register src="UserControl/Header.ascx" tagname="Header" tagprefix="uc1" %>
<%@ Register src="UserControl/Footer.ascx" tagname="Footer" tagprefix="uc2" %>

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
        .auto-style5 {
            width: 736px;
        }
        .auto-style8 {
            font-size: large;
            width: -39;
        }
        .auto-style9 {
            width: 367px;
            height: 134px;
        }
        .auto-style10 {
            width: 367px;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server" defaultButton="btnSubmit" defaultFocus="tbName">
        <div>
            <uc1:Header ID="Header1" runat="server" />
            <table class="auto-style5">
                <tr>
                    <td class="auto-style8" colspan="2">
                        <h1>User Information:</h1>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">Name:</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="tbName" runat="server" Width="148px" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="tbName" Display="Dynamic" ErrorMessage="Name is required" Font-Bold="True" Font-Italic="True" ForeColor="Fuchsia">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">Date of birth:</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="tbDate" runat="server" Font-Bold="True" Font-Italic="True" TextMode="Date" ViewStateMode="Disabled"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvBirth" runat="server" ControlToValidate="tbDate" Display="Dynamic" ErrorMessage="The birth day is required" Font-Bold="True" Font-Italic="True" ForeColor="Fuchsia">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">E-mail:</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="tbEmail" runat="server" Width="149px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="tbEmail" Display="Dynamic" ErrorMessage="Please provide an e-mail" ForeColor="Fuchsia">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbEmail" Display="Dynamic" ErrorMessage="Please provid a valid e-mail adress" ForeColor="Fuchsia" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">Province</td>
                    <td class="auto-style10">
                        <asp:DropDownList ID="ddlProvince" InitialValue="-1" runat="server" Width="160px" AutoPostBack="True" OnSelectedIndexChanged="ddlProvince_SelectedIndexChanged">
                            <asp:ListItem Selected="True">Please select</asp:ListItem>
                            <asp:ListItem>Quebec</asp:ListItem>
                            <asp:ListItem>Ontario</asp:ListItem>
                            <asp:ListItem>British Columbia</asp:ListItem>
                            <asp:ListItem>Alberta</asp:ListItem>
                            <asp:ListItem>New Brunswick</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvProvince" runat="server" ControlToValidate="ddlProvince" ErrorMessage="Please select your province" ForeColor="Fuchsia">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">City</td>
                    <td class="auto-style10">
                        <asp:DropDownList ID="ddlCity" runat="server" InitialValue="-1" Width="160px">
                            <asp:ListItem>Please select</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvCity" runat="server" ControlToValidate="ddlProvince" ErrorMessage="Please select your city" ForeColor="Fuchsia">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" Width="178px" />
                    </td>
                    <td class="auto-style10">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9" >
                        <asp:Label ID="lblPrint" runat="server" Font-Bold="True" ForeColor="Maroon" Text="..."></asp:Label>
                    </td>
                    <td class="auto-style10">
                       
                    </td>
                </tr>
            </table>
        </div>
        <input type="hidden" id="hidVal" name="hidVal" runat="server" value="0" />
        <asp:ValidationSummary ID="vsForm" runat="server" Font-Bold="True" Font-Italic="False" ForeColor="#FF3399" />
        <br />
        <asp:ListBox ID="lbRecord" runat="server" Width="736px"></asp:ListBox>
        <uc2:Footer ID="Footer1" runat="server" />
    </form>
</body>
</html>
