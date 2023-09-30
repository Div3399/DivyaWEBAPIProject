<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="WeltecDemo.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td>User Name</td>
                    <td><asp:TextBox ID="txtusername" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td><asp:TextBox ID="txtPswd" Textmode="Password" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td><asp:Button ID="btnLogIn" Onclick="btnLogIn_Click" runat="server" Text="Sign In" /></td>
                    <td>&nbsp;</td>
                </tr> 
                <tr>
                    <td>&nbsp;</td>
                    <td><asp:Label ID="lblmsg" ForeColor="green" runat="server" Text=""></asp:Label></td>
                    <td>&nbsp;</td>
                    
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
