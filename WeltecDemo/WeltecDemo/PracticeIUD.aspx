<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PracticeIUD.aspx.cs" Inherits="WeltecDemo.PracticeIUD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
            <asp:Panel ID="Panellist" runat="server">
                <table style="width: 100%;">
                <tr>
                    <td>
                        <asp:TextBox ID="txtSearch" OntextChanged="txtSearch_TextChanged" AutoPostBack="true" runat="server"></asp:TextBox>
                        <asp:Button ID="btnSearch" OnClick="btnSearch_Click" runat="server" Text="Search" />
                        <asp:Button ID="btnAdd" OnClick="btnAdd_Click" runat="server" Text="Add" />
                    </td>
                </tr>
                <tr>
                    <td> <asp:GridView ID="Employees" AutoGenerateColumns="false" PageSize="10" AllowPaging="true" OnRowCommand="Employees_RowCommand"
                        OnPageIndexChanging="Employees_PageIndexChanging" runat="server">
                <Columns>
                    <asp:TemplateField  HeaderText="SrNo.">
                        <ItemTemplate>
                            <asp:Label ID="lblSrNo" runat="server" Text='<%#Container.DataItemIndex + 1 %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                   
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:CheckBox ID="CheckBox1" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField  HeaderText="FirstName">
                        <ItemTemplate>
                            <asp:Label ID="lblFname" runat="server" Text='<%#Eval("first_name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField  HeaderText="LasttName">
                        <ItemTemplate>
                            <asp:Label ID="lblLname" runat="server" Text='<%#Eval("last_name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField  HeaderText ="Gender">
                        <ItemTemplate>
                             <asp:Label ID="lblGender" runat="server" Text='<%#Eval("gender") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField  HeaderText="Age">
                        <ItemTemplate>
                             <asp:Label ID="lblAge" runat="server" Text='<%#Eval("age") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField  HeaderText="Phone No">
                        <ItemTemplate>
                             <asp:Label ID="lblPhone" runat="server" Text='<%#Eval("phone") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnEdit" CommandName="EditId" CommandArgument='<%#Eval("ID") %>' runat="server" Text="Edit" />
                            <asp:Button ID="btnView" CommandName="ViewId" CommandArgument='<%#Eval("ID") %>' runat="server" Text="View" />
                            <asp:Button ID="btnDelete" CommandName="DltId" CommandArgument='<%#Eval("ID") %>' runat="server" Text="Delete" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView></td>
                </tr>
            </table>
            </asp:Panel>

            <asp:Panel ID="PanelADD" Visible="false" runat="server">

                <table style="width: 100%;">
                    <tr>
                        <td>First Name</td>
                        <td><asp:TextBox ID="txtFname" runat="server"></asp:TextBox></td>   
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>Last Name</td>
                        <td><asp:TextBox ID="txtlastname" runat="server"></asp:TextBox></td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>Gender</td>
                        <td><asp:TextBox ID="txtGender" runat="server"></asp:TextBox></td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>Age</td>
                        <td><asp:TextBox ID="txtAge" runat="server"></asp:TextBox></td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>Phone no</td>
                        <td><asp:TextBox ID="txtphone" runat="server"></asp:TextBox></td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td><asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" Text="Submit" />
                           <asp:Button ID="btnCancel" OnClick="btnCancel_Click" runat="server" Text="Cancel" />
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><asp:Label ID="lblmsg"  runat="server" Text="" ForeColor="ForestGreen"></asp:Label></td>
                        <td>&nbsp;</td>
                    </tr>
                </table>

            </asp:Panel>
            

        <asp:Panel ID="PanelView" Visible="false" runat="server">
            <table style="width: 100%;">
                <tr>
                    <td>First Name</td>
                    <td>
                        <asp:Label ID="lblfname" runat="server" Text="Label"></asp:Label></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Last Name</td>
                    <td>
                        <asp:Label ID="lblLname" runat="server" Text="Label"></asp:Label></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Gender</td>
                    <td>
                        <asp:Label ID="lblgen" runat="server" Text="Label"></asp:Label></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Age</td>
                    <td>
                        <asp:Label ID="lblage" runat="server" Text="Label"></asp:Label></td>
                    <td>&nbsp;</td>
               </tr>
                <tr>
                    <td>Phone no.</td>
                    <td>
                        <asp:Label ID="lblphn" runat="server" Text="Label"></asp:Label></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnBack" OnClick="btnBack_Click" runat="server" Text="Back" /></td>
                    <td>&nbsp;</td>
                </tr>
                
            </table>

        </asp:Panel>
      
    </form>
</body>
</html>
