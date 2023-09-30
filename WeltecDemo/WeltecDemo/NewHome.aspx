<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewHome.aspx.cs" Inherits="WeltecDemo.NewHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%--<div>
            <asp:Label ID="lblEmpId" runat="server" Text=""></asp:Label><br /><br />
           <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
        </div>--%>

        <asp:Panel ID="PanelList" runat="server">

            <table style="width: 100%;">
                <tr>
                    <td>
                        <asp:TextBox ID="txtSearch" OnTextChanged="txtSearch_TextChanged" AutoPostBack="true" runat="server"></asp:TextBox>
                         <asp:Button ID="btnSearch" OnClick="btnSearch_Click" runat="server" Text="Search" />
                          <asp:Button ID="btnAdd" OnClick="btnAdd_Click" runat="server" Text="Add New" />
                    </td>
                    
                </tr>
                <tr>
                    <td> <asp:GridView ID="GridViewEmployees" AutoGenerateColumns="false" Pagesize="10" AllowPaging="true" OnRowCommand="GridViewEmployees_RowCommand"
            OnPageIndexChanging="GridViewEmployees_PageIndexChanging" runat="server" >
             
            <Columns>
                <asp:TemplateField HeaderText="Sr No.">
                    <ItemTemplate>
                       <asp:Label ID="SrNo" runat="server" Text='<%#Container.DataItemIndex  + 1%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="First Name">
                    <ItemTemplate>
                        <asp:Label ID="lblfName" runat="server" Text='<%#Eval("first_name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText ="Last Name">
                    <ItemTemplate>
                        <asp:Label ID="lblLname" runat="server" Text='<%#Eval("last_name") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField  HeaderText="Phone No">
                    <ItemTemplate>
                         <asp:Label ID="lblphone" runat="server" Text='<%#Eval("phone") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnEdit"  CommandName="EditEmp" CommandArgument='<%# Eval("ID") %>' runat="server" Text="EDIT" />
                        <asp:Button ID="btnView" CommandName="ViewEmp" CommandArgument= '<%# Eval ("ID") %>' runat="server" Text="VIEW" />
                        <asp:Button ID="btnDlt" CommandName="DeleteEmp" CommandArgument='<%# Eval("ID") %>'  runat="server" Text="DELETE" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
           </asp:GridView></td>
                    
                </tr>
            </table>
        </asp:Panel>


        <asp:Panel ID="PanelAdd" Visible="false" runat="server">

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
                    <td>phone</td>
                    <td><asp:TextBox ID="txtphone" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                 <tr>
                 
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnSubmit" onclick="btnSubmit_Click1" runat="server" Text="Submit" />
                        <asp:Button ID="btnCancel" onclick="btnCancel_Click" runat="server" Text="Cancel" />
  
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
        </asp:Panel>


        <asp:Panel ID="PanelView" Visible="false" runat="server">

            <table style="width: 100%;">
                <tr>
                    <td>First_name</td>
                    <td>
                        <asp:Label ID="lblfname" runat="server" Text="Label"></asp:Label> 
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Last_Name</td>
                    <td>
                        <asp:Label ID="lblLname" runat="server" Text="Label"></asp:Label> 
                     </td>
                    <td>&nbsp;</td>
                </tr>
                
                 <tr>
                    <td>phone</td>
                    <td> <asp:Label ID="lblphone" runat="server" Text="Label"></asp:Label> </td>
                    <td>&nbsp;</td>
                </tr>
                 <tr>
                 
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnBack" OnClick="btnBack_Click"  runat="server" Text="Back" />
                       
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
       
         
          
    </form>
</body>
</html>

