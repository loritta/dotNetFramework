<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="InvestmentCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 64%;
        }
        .auto-style2 {
            width: 328px;
        }
        .auto-style3 {
            font-size: large;
        }
        .auto-style4 {
            width: 328px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
    </style>
</head>
<body style="width: 1070px">
    <form id="form1" runat="server">
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
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <h5>Investment</h5>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtInvestment" runat="server" Width="150px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <h5>Annual Interest Rate</h5>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlRate" runat="server" Width="150px">
                        
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <h5>Number of years</h5>
                    </td>
                    <td>
                        <asp:TextBox ID="txtYears" runat="server" Width="150px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnCalc" runat="server" Text="Calculate" Width="100px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnClear" runat="server" Text="Button" Width="100px" />
                    </td>
                    <td>&nbsp;</td>
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
