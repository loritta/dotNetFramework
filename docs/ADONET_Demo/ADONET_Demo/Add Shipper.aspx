<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add Shipper.aspx.cs" Inherits="ADONET_Demo.Add_Shipper" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 365px;
        }
        .auto-style4 {
            height: 23px;
            width: 365px;
        }
        .auto-style5 {
            width: 251px;
        }
        .auto-style6 {
            height: 23px;
            width: 251px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>New Shipper Form</h1>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">Company Name</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="Name is a required field" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Phone Number</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtPhone" runat="server" TextMode="Phone"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ControlToValidate="txtPhone" ErrorMessage="Phone is a required field" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">
                        <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Insert" Width="126px" />
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
