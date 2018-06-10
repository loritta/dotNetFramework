<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CheckOutPage._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style5 {
            width: 223px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
        .auto-style8 {
            width: 223px;
        }
        .auto-style9 {
            width: 222px;
        }
        .auto-style10 {
            width: 222px;
            height: 22px;
        }
        .auto-style11 {
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Checkout page</h1>
        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Italic="True" ForeColor="Red" HeaderText="Please correct these entries:" />
        <h3>Contact Information</h3>
        <table class="auto-style1">
            <tr>
                <td class="auto-style8">Email address:</td>
                <td>
                    <asp:TextBox ID="tbEmail" runat="server" Width="192px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ErrorMessage="Email address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="tbEmail" Display="Dynamic" ForeColor="Red">Must be a valid e-mail address</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Email Re-entry:</td>
                <td>
                    <asp:TextBox ID="tbReEmail" runat="server" Width="192px"></asp:TextBox>
                    <asp:CompareValidator ID="cvEmail" runat="server" ControlToCompare="tbEmail" ControlToValidate="tbReEmail" Display="Dynamic" ErrorMessage="Email re-entry" ForeColor="Red">Must match first e-mail address</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">First Name:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="tbFName" runat="server" Width="192px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvFName" runat="server" ErrorMessage="First Name" ForeColor="Red" ControlToValidate="tbFName" Display="Dynamic">Required</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Last Name:</td>
                <td>
                    <asp:TextBox ID="tbLName" runat="server" Width="192px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvLName" runat="server" ErrorMessage="Last Name" ForeColor="Red" ControlToValidate="tbLName" Display="Dynamic">Required</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Phone Number:</td>
                <td>
                    <asp:TextBox ID="tbPhone" runat="server" Width="192px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="revPhone" runat="server" ControlToValidate="tbPhone" Display="Dynamic" ErrorMessage="Phone number" ForeColor="Red" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">Use this format: 123-456-7890</asp:RegularExpressionValidator>
                </td>
            </tr>
        </table>
        <h3>Billing Address</h3>
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">Address:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="tbAddress" runat="server" Width="192px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvBAddress" runat="server" ErrorMessage="Billing address" ForeColor="Red" ControlToValidate="tbAddress" Display="Dynamic">Required</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">City:</td>
                <td>
                    <asp:TextBox ID="tbCity" runat="server" Width="192px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvBCity" runat="server" ErrorMessage="Billing city" ForeColor="Red" ControlToValidate="tbCity" Display="Dynamic">Required</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Province:</td>
                <td>
                    <asp:DropDownList ID="ddlState" runat="server" Width="200px">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvBState" runat="server" ErrorMessage="Billing province" ForeColor="Red" ControlToValidate="ddlState" Display="Dynamic">Required</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Zip Code:</td>
                <td>
                    <asp:TextBox ID="tbZip" runat="server" Width="192px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="revZip" runat="server" ControlToValidate="tbZip" Display="Dynamic" ErrorMessage="Billing Zip Code" ForeColor="Red" ValidationExpression="[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]">Use this format: A1B 2C3</asp:RegularExpressionValidator>
                </td>
            </tr>
        </table>
        <h3>Shipping Address</h3>
        <p>
            <asp:CheckBox ID="cbShippingAddress" runat="server" Text="Same as billing address" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
        </p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style10">Address:</td>
                <td class="auto-style11">
                    <asp:TextBox ID="tbShipAddress" runat="server" Width="192px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvSAddress" runat="server" ErrorMessage="Shipping address" ForeColor="Red" ControlToValidate="tbShipAddress" Display="Dynamic" Enabled="False">Required</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">City:</td>
                <td>
                    <asp:TextBox ID="tbShipCity" runat="server" Width="192px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvSCity" runat="server" ErrorMessage="Shipping city" ForeColor="Red" ControlToValidate="tbShipCity" Display="Dynamic" Enabled="False">Required</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">State:</td>
                <td>
                    <asp:DropDownList ID="ddlShipState" runat="server" Width="200px">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvSState" runat="server" ErrorMessage="Shipping province" ForeColor="Red" ControlToValidate="ddlShipState" Display="Dynamic" Enabled="False">Required</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Zip Code:</td>
                <td>
                    <asp:TextBox ID="tbShipZip" runat="server" Width="192px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="revShipZip" runat="server" ControlToValidate="tbShipZip" Display="Dynamic" Enabled="False" ErrorMessage="Shipping Zip Code" ForeColor="Red" ValidationExpression="[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]">Use this format: A1B 2C3</asp:RegularExpressionValidator>
                </td>
            </tr>
        </table>
        <p>
            <asp:Button ID="btnCheckout" runat="server" Text="Check out" OnClick="btnCheckout_Click" />
        </p>
        <asp:ListBox ID="lbResult" runat="server" Height="140px" Width="427px" Visible="False"></asp:ListBox>
    </form>
</body>
</html>
