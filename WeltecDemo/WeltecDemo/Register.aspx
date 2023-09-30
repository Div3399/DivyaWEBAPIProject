<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WeltecDemo.Register" %>

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
                    <td>First_name</td>
                    <td>
                        <asp:TextBox ID="txtFname" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Last_Name</td>
                    <td>
                        <asp:TextBox ID="txtLname" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Age</td>
                    <td><asp:TextBox ID="txtAge" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>BloodGroupId</td>
                    <td>
                        <asp:DropDownList ID="ddlBlood" runat="server" Height="22px" Width="164px"></asp:DropDownList></td>
                    <td>&nbsp;</td>
                </tr>
                 <tr>
                    <td>phone</td>
                    <td><asp:TextBox ID="txtphone" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                 <tr>
                    <td>Country</td>
                    <td>
                        <asp:DropDownList ID="ddlCountry" runat="server" Height="22px" Width="164px"></asp:DropDownList></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnSubmit" Onclick="btnSubmit_Click" runat="server" Text="Submit" />
                        <asp:Button ID="btnSubmitWithClass" Onclick="btnSubmitWithClass_Click" runat="server" Text="Submit With Class" />
                        <asp:Button ID="btSubSubmit" Onclick="btSubSubmit_Click" runat="server" Text="Sub Submit" />
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
           
            <asp:GridView ID="GridviewEmdata" runat="server"></asp:GridView>

             <asp:CheckBoxList ID="CheckBoxblood" runat="server"></asp:CheckBoxList>
        </div>
    </form>
</body>
</html>
