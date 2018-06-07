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
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Italic="True" ForeColor="Red" />
        <h3>Contact Information</h3>
        <table class="auto-style1">
            <tr>
                <td class="auto-style8">Email address:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="192px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="You should enter a valid e-mail" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvEmail" runat="server" Display="Dynamic" ErrorMessage="RangeValidator" Font-Italic="True" ForeColor="Red">*</asp:RangeValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Email Re-entry:</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="192px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvReEmail" runat="server" ErrorMessage="You should enter a valid e-mail" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvReEmail" runat="server" Display="Dynamic" ErrorMessage="RangeValidator" Font-Italic="True" ForeColor="Red">*</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">First Name:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox3" runat="server" Width="192px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvFName" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Last Name:</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" Width="192px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvLName" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Phone Number:</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server" Width="192px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <h3>Billing Address</h3>
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">Address:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox6" runat="server" Width="192px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvAddress" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">City:</td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server" Width="192px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCity" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">State:</td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" Width="200px">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvState" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Zip Code:</td>
                <td>
                    <asp:TextBox ID="TextBox8" runat="server" Width="192px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvZip" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <h3>Shipping Address</h3>
        <p>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Same as billing address" />
        </p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style10">Address:</td>
                <td class="auto-style11">
                    <asp:TextBox ID="TextBox9" runat="server" Width="192px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvAddress0" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">City:</td>
                <td>
                    <asp:TextBox ID="TextBox10" runat="server" Width="192px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCity0" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">State:</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="200px">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfvState0" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Zip Code:</td>
                <td>
                    <asp:TextBox ID="TextBox11" runat="server" Width="192px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvZip0" runat="server" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <p>
            <asp:Button ID="btnCheckout" runat="server" Text="Check out" />
        </p>
        <asp:ListBox ID="ListBox1" runat="server" Height="140px" Width="427px"></asp:ListBox>
    </form>
</body>
</html>
