<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreatProduct.aspx.cs" Inherits="Lab01.Admin.CreatProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 42%;
            border: 1px solid #00FFFF;
        }
        .auto-style2 {
            font-size: medium;
        }
        .auto-style3 {
            text-align: left;
        }
        .auto-style4 {
            font-size: medium;
            text-align: right;
        }
        .auto-style5 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="text-align: center">
                <asp:Label ID="Label1" runat="server" Text="Create New Product"></asp:Label>
                <br />
                <asp:Label ID="lblWWel" runat="server" CssClass="auto-style2" ForeColor="Red" Text="[Label]"></asp:Label>
            </h2>
            <h2 style="text-align: center">
                <asp:Label ID="lblMessage" runat="server" CssClass="auto-style2" ForeColor="Red"></asp:Label>
                <br />
                <table align="center" class="auto-style1">
                    <tr>
                        <td class="auto-style4">Product Name:</td>
                        <td class="auto-style3">
                            <asp:TextBox ID="txtName" runat="server" style="text-align: left" Width="253px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">Unit Price:</td>
                        <td class="auto-style3">
                            <asp:TextBox ID="txtPrice" runat="server" style="text-align: left" Width="253px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">Quantity:</td>
                        <td class="auto-style3">
                            <asp:TextBox ID="txtQuantity" runat="server" style="text-align: left" Width="253px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">Photo:</td>
                        <td class="auto-style3">
                            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="auto-style5" Width="262px" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="Button1" runat="server" CssClass="auto-style2" Height="42px" Text="Create" Width="107px" OnClick="Button1_Click" />
                        </td>
                    </tr>
                </table>
            </h2>
        </div>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="225px" Width="1574px">
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
    </form>
</body>
</html>
