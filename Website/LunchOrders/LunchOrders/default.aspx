<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="LunchOrders._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="css/main.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 198px;
        }
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            width: 198px;
            height: 74px;
        }
        .auto-style5 {
            height: 74px;
        }
        .auto-style6 {
            width: 198px;
            height: 31px;
        }
        .auto-style7 {
            height: 31px;
        }
    </style>
</head>
<body> 
    <section>
            <h1 class="auto-style3">National Conference</h1>
            <h4 class="auto-style3">
                <br />
                Meel Orders</h4>
        </section>
    <section>
    <form id="form1" runat="server">
       
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Order number:</td>
                <td>
                    <asp:Label ID="lblOrderNumber" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Name of the participant:</td>
                <td>
                    <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">City:</td>
                <td>
                    <asp:ListBox ID="lbCity" runat="server" AutoPostBack="True" DataTextField="Name" DataValueField="ID" OnSelectedIndexChanged="lbCity_SelectedIndexChanged" Width="504px"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Gender:</td>
                <td>
                    <asp:DropDownList ID="ddlGender" runat="server" AutoPostBack="True" DataTextField="Name" DataValueField="ID" Width="500px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Meal Options:</td>
                <td>
                    <asp:CheckBoxList ID="cblMeal" runat="server" AutoPostBack="True" DataTextField="Name" DataValueField="ID">
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Payment Method:</td>
                <td class="auto-style7">
                    <asp:RadioButtonList ID="rblPayment" runat="server" AutoPostBack="True" DataTextField="Name" DataValueField="ID">
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" Width="350px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Your order:</td>
                <td class="auto-style5">
                    <asp:ListBox ID="lbOrder" runat="server" AutoPostBack="True" DataTextField="Text" DataValueField="Value" Width="496px"></asp:ListBox>
                </td>
            </tr>
        </table>
    </form>
        </section>
</body>
</html>
