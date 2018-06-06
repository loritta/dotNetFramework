<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InvestmentCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 92%;
        }
        .auto-style2 {
            width: 265px;
        }
        .auto-style3 {
            font-size: large;
        }
        .auto-style4 {
            width: 265px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
    </style>
</head>
<body style="width: 1070px">
    <form id="form1" runat="server" defaultButton="btnCalc" defaultFocus="txtName">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3" colspan="2">
                        <h1>Investment Calculator</h1>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <h5>Name</h5>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" Width="150px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" Display="Dynamic" ErrorMessage="*Name is required" Font-Bold="True" ForeColor="Maroon" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <h5>Annual Interest Rate</h5>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtRate" runat="server" Width="150px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvRate" runat="server" ControlToValidate="txtRate" Display="Dynamic" ErrorMessage="*Rate is required" Font-Bold="True" ForeColor="Maroon">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvRate" runat="server" ControlToValidate="txtRate" Display="Dynamic" ErrorMessage="*Rate has to be between 1.0 and 20.0" Font-Bold="True" ForeColor="Maroon" MaximumValue="20" MinimumValue="1" SetFocusOnError="True" Type="Double">*</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <h5>Investment</h5>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlInvest" runat="server" Width="158px">
                        
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvInvest" runat="server" ControlToValidate="ddlInvest" Display="Dynamic" ErrorMessage="*Please select a value" Font-Bold="True" ForeColor="Maroon">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <h5>Number of years</h5>
                    </td>
                    <td>
                        <asp:TextBox ID="txtYears" runat="server" Width="150px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvYears" runat="server" ControlToValidate="txtYears" Display="Dynamic" ErrorMessage="*Number of years is required" Font-Bold="True" ForeColor="Maroon">*</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="cvYears" runat="server" ControlToValidate="txtYears" Display="Dynamic" ErrorMessage="*It has to be an integer number" Font-Bold="True" ForeColor="Maroon" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                        <asp:RangeValidator ID="rvYears" runat="server" ControlToValidate="txtYears" Display="Dynamic" ErrorMessage="*Number of years should be between 1 and 45" Font-Bold="True" ForeColor="Maroon" MaximumValue="45" MinimumValue="1">*</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnCalc" runat="server" Text="Calculate" Width="100px" OnClick="btnCalc_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnClear" runat="server" Text="Clear" Width="100px" OnClick="btnClear_Click" />
                    </td>
                    <td>
                        <asp:ValidationSummary ID="vsForm" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="Maroon" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblResult" runat="server" Text="..."></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
