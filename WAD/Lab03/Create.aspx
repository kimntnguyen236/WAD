<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Lab03.Create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 60%;
            border: 6px solid #000000;
        }
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style3 {
            font-size: large;
        }
        .auto-style5 {
            height: 39px;
            text-align: center;
        }
        .auto-style7 {
            font-weight: bold;
        }
        .auto-style10 {
            height: 35px;
        }
        .auto-style11 {
            width: 1494px;
        }
        .auto-style12 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style11">
        <div>
            <table align="center" class="auto-style1">
                <tbody class="auto-style12">
                    <tr>
                        <td class="auto-style2"><strong>Create new Country<br />
                            <asp:Label ID="lblMess" runat="server" CssClass="auto-style3" Text="[lblMess]"></asp:Label>
                            <br />
                            </strong></td>
                    </tr>
                    <tr>
                        <td class="auto-style10"><strong>
                            <asp:Label ID="Label1" runat="server" CssClass="auto-style3" Text="Country Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtName" runat="server" Width="346px"></asp:TextBox>
&nbsp;&nbsp;
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Not blank...." SetFocusOnError="True"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtName" ErrorMessage="CountryName From 3 to 20 charector" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^[a-zA-Z]{3,20}$"></asp:RegularExpressionValidator>
                            </strong></td>
                    </tr>
                    <tr>
                        <td class="auto-style10"><strong>
                            <asp:Label ID="Label2" runat="server" CssClass="auto-style3" Text="Population:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtPop" runat="server" Width="346px"></asp:TextBox>
                            </strong></td>
                    </tr>
                    <tr>
                        <td class="auto-style10"><strong>
                            <asp:Label ID="Label3" runat="server" CssClass="auto-style3" Text="Language Code:"></asp:Label>
&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtCode" runat="server" Width="348px"></asp:TextBox>
                            </strong></td>
                    </tr>
                    <tr>
                        <td class="auto-style10"><strong>
                            <asp:Label ID="Label4" runat="server" CssClass="auto-style3" Text="Image:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:FileUpload ID="FileUpload1" runat="server" Width="354px" />
                            </strong></td>
                    </tr>
                    <tr>
                        <td class="auto-style5"><strong>
                            <asp:Button ID="Button1" runat="server" CssClass="auto-style7" Text="Create New" OnClick="Button1_Click" />
                            </strong></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </form>
</body>
</html>
