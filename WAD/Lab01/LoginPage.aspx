<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Lab01.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 42%;
            border: 1px solid #000000;
            background-color: cadetblue;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            font-size: xx-large;
        }
        .auto-style4 {
            text-align: left;
            width: 568px;
        }
        .auto-style5 {
            height: 40px;
        }
        .auto-style6 {
            text-align: left;
            width: 568px;
            height: 40px;
        }
        .auto-style7 {
            text-align: center;
            height: 99px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
    <table cellpadding="5" cellspacing="5" class="auto-style1" align="center">
        <tr>
            <td class="auto-style7" colspan="2">
                <asp:Label ID="Label4" runat="server" Text="LOGIN" CssClass="auto-style3" Font-Bold="True" ForeColor="Lime"></asp:Label>
                <br />
                <strong>
                <asp:Label ID="Error" runat="server" Font-Size="Medium" ForeColor="#FF3300" Text="[Label]"></asp:Label>
                </strong>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LabelUser" runat="server" Text="UserName"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="txtName" runat="server" Width="295px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="User name is required..!!" ForeColor="Red" ControlToValidate="txtName" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="labelPass" runat="server" Text="Password"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="txtPassword" runat="server" Width="295px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="auto-style2">
                <asp:Button ID="btnSubmit" runat="server" Text="Sign In" ForeColor="Black" OnClick="btnSubmit_Click" />
            </td>
        </tr>
    </table>
    </form>
    </body>
</html>
