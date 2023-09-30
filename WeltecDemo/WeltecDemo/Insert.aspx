<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="WeltecDemo.Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table style="width: 100%;">
                <tr>
                    <td>Last_name</td>
                    <td>
                        <asp:TextBox ID="txtLname" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnDelete" Onclick="btnDelete_Click" runat="server" Text="Delete" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="lblmsg" runat="server" Text="" ForeColor="#FF3300"></asp:Label></td>
                    <td>&nbsp;</td>
                </tr>
        </table>
    </form>
</body>
</html>
