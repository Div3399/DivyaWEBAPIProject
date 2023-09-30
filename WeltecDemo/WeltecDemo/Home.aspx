<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WeltecDemo.Home" %>

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
                    <td>No1</td>
                    <td>
                        <asp:TextBox ID="txtNo1" runat="server"></asp:TextBox>

                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>No2</td>
                    <td><asp:TextBox ID="txtNo2" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                 <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSum" Onclick="btnSum_Click" runat="server" Text="Sum" />
                        <asp:Button ID="btnSub" Onclick="btnSub_Click" runat="server" Text="Sub" />
                        <asp:Button ID="btnMulty" Onclick="btnMulty_Click" runat="server" Text="multy" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Result</td>
                    <td>
                        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
