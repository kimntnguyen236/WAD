<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="Lab01.View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 55px;
        }
        .auto-style2 {
            font-size: xx-large;
        }
        .auto-style3 {
            width: 95%;
            height: 343px;
            margin-right: 9px;
        }
        .auto-style4 {
            text-align: justify;
            width: 214px;
        }
        .auto-style6 {
            width: 155px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        </div>
        <p class="auto-style1">
            <asp:Label ID="Label3" runat="server" CssClass="auto-style2" Text="List of Products"></asp:Label>
        </p>
        <p class="auto-style1">
            <asp:TextBox ID="TextBox1" runat="server" Width="226px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Filter" Width="108px" />
        </p>
        <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="3" RepeatColumns="3" OnItemCommand="DataList1_ItemCommand">
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <ItemStyle BackColor="#DEDFDE" ForeColor="Black" />
            <ItemTemplate>
                <table cellpadding="4" cellspacing="4" class="auto-style3">
                    <tr>
                        <td class="auto-style4" rowspan="3">
                            <asp:Image ID="Image1" runat="server" Height="303px" ImageUrl='<%# Eval("Photo") %>' Width="355px" />
                        </td>
                        <td class="auto-style6">Product name :<br />
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">Unit Price:
                            <asp:Label ID="Label5" runat="server" ForeColor="#FF3300" Text='<%# Bind("Price") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("Id") %>' CommandName="banana">View Detail</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
        </asp:DataList>
    </form>
</body>
</html>
