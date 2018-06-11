<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddShipper.aspx.cs" Inherits="ADONET_Demo.AddShipper" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 270px;
        }
        .auto-style3 {
            width: 320px;
        }
        .auto-style4 {
            width: 270px;
            height: 26px;
        }
        .auto-style5 {
            width: 320px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>New Shipper Form</h1>
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Company Name</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="tbName" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Phone Number</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="tbPhone" runat="server" TextMode="Phone"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ControlToValidate="tbPhone" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" Width="125px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </form>
</body>
</html>
