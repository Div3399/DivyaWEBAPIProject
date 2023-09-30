<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="WeltecDemo.Employee" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
       
        <asp:Panel ID="PanelADD" visible="true" runat="server">
            <h2 style="text-align:center"><b>Registration Form</b></h2>

            <table style="width: 100%;">
                <tr>
                    <td>Branch</td>
                    <td>Role</td>
                    <td>Joining date</td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlBranch" runat="server" Height="29px" Width="340px"></asp:DropDownList></td>                  
                    <td>
                        <asp:DropDownList ID="ddlRole" runat="server" Height="23px" Width="265px"></asp:DropDownList></td>
                    <td>
                        <asp:TextBox ID="txtjoining" TextMode="Date" runat="server" Height="22px" Width="336px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Employee No.</td>
                    <td>First Name</td>
                    <td>Last Name</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtEmpNo" runat="server" Height="28px" Width="336px"></asp:TextBox></td>
                    <td>
                        <asp:TextBox ID="txtFname" runat="server" Height="30px" Width="256px"></asp:TextBox></td>
                    <td>
                        <asp:TextBox ID="txtlname" runat="server" Height="24px" Width="332px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Gender</td>
                    <td>BirthDate</td>
                    <td>MobileNo.</td>
                </tr>
                 <tr>
                    <td>
                        <asp:RadioButtonList ID="rdbtn" runat="server" >
                            <asp:ListItem Text="Male"></asp:ListItem>
                            <asp:ListItem Text="Feamle"></asp:ListItem>
                        </asp:RadioButtonList>                      
                    </td>
                    <td>
                        <asp:TextBox ID="txtBirth" TextMode="Date" runat="server" Height="21px" Width="254px"></asp:TextBox></td>
                    <td>
                        <asp:TextBox ID="txtMobile" runat="server" Height="26px" Width="320px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Home Mobile No</td>
                    <td>Email Id</td>
                    <td>Current Address</td>
                </tr>
                <tr>
                    <td><asp:TextBox ID="txtHoMoNo" runat="server" style="margin-top: 0px" Height="24px" Width="332px"></asp:TextBox></td>
                    <td><asp:TextBox ID="txtemailId" runat="server" Height="28px" Width="275px"></asp:TextBox></td>
                    <td><asp:TextBox ID="txtCuAdd" runat="server" Height="46px" Width="333px"></asp:TextBox></td>
                </tr>

                 <tr>
                     <td>Hobbies</td>
                    <td>
                        <asp:CheckBoxList ID="ChckHobbies"  runat="server"></asp:CheckBoxList>

                    </td>
                    <td>&nbsp;</td>
                </tr>
                
                <tr>
                     <td>Upload Image</td>
                    <td>
                        <asp:FileUpload ID="FileUpload1"  runat="server"  />
                        <asp:Button ID="Btnupload" OnClick="Btnupload_Click" runat="server" Text="Upload Image" Height="29px" Width="192px" />
                        <br />
                        <br />
                        <asp:Label ID="lblImg" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Image ID="Image1" runat="server" Height="100px" Width="335px" ImageUrl="~/Image" /></td>
                </tr>

                 <tr>
                     <td>
                         &nbsp;</td>
                    <td>
                        <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" Text="Submit" />
                        <asp:Button ID="btncancel" Onclick="btncancel_Click1" runat="server" Text="Cancel" />
                    </td>
                    <td></td>
                    
                </tr>

                <tr>
                     <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="lblmsg" runat="server" Text="" ForeColor="DarkBlue"></asp:Label></td>
                    <td>&nbsp;</td>
                </tr>
                
               
            </table>
        </asp:Panel>
        


        
        <asp:Panel ID="Panellist" Visible="false"  runat="server">
            <table style="width: 100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtSearch" OntextChanged="txtSearch_TextChanged" AutoPostBack="true" runat="server"></asp:TextBox>
                        <asp:Button ID="btnSearch" OnClick="btnSearch_Click" runat="server" Text="Search" />
                        <asp:DropDownList ID="ddlBranchD" runat="server" Height="16px" Width="161px"></asp:DropDownList>
                        <asp:DropDownList ID="ddlRoleD" runat="server" Height="16px" Width="177px"></asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:GridView ID="EmpDetails" AutoGenerateColumns="false" OnPageIndexChanging="EmpDetails_PageIndexChanging" 
                        OnRowCommand="EmpDetails_RowCommand" runat="server">
            <Columns>
                <asp:TemplateField HeaderText =" SrNo.">
                    <ItemTemplate>
                        <asp:Label ID="lblSrNo" runat="server" Text='<%#Container.DataItemIndex + 1 %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText =" EmployeeNo.">
                    <ItemTemplate>
                        <asp:Label ID="lblEmployeeNo" runat="server" Text='<%#Eval("EmployeeNo") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText =" First Name">
                    <ItemTemplate>
                        <asp:Label ID="lblFname" runat="server" Text='<%#Eval("FirstName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText =" Last Name">
                    <ItemTemplate>
                        <asp:Label ID="lblLname" runat="server" Text='<%#Eval("LastName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText =" Gender">
                    <ItemTemplate>
                        <asp:Label ID="lblGender" runat="server" Text='<%#Eval("Gender") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText =" BirthDate">
                    <ItemTemplate>
                        <asp:Label ID="lblBOD" runat="server" Text='<%#Eval("BirthDate") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText =" MobileNo.">
                    <ItemTemplate>
                        <asp:Label ID="lblMObNo" runat="server" Text='<%#Eval("MobileNo") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText =" HomeMob No">
                    <ItemTemplate>
                        <asp:Label ID="lblHomeMob" runat="server" Text='<%#Eval("HomeMObileNo") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText =" Email Id">
                    <ItemTemplate>
                        <asp:Label ID="lblEmail" runat="server" Text='<%#Eval("EmailId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText =" Address">
                    <ItemTemplate>
                        <asp:Label ID="lblCurrentAdd" runat="server" Text='<%#Eval("Address") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText =" Joining Date">
                    <ItemTemplate>
                        <asp:Label ID="lbljoiningdate" runat="server" Text='<%#Eval("JoiningDate") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText ="Branch ID">
                    <ItemTemplate>
                        <asp:Label ID="lblBranch" runat="server" Text='<%#Eval("BranchId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                 <asp:TemplateField HeaderText =" Role ID">
                    <ItemTemplate>
                        <asp:Label ID="lblRole" runat="server" Text='<%#Eval("RoleId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText ="Hobbies">
                    <ItemTemplate>
                        <asp:Label ID="lblHobbies" runat="server" Text='<%#Eval("HobbiesId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText ="Profile Picture">
                    <ItemTemplate>
                        <asp:Label ID="lblImage" runat="server" ImageUrl='<%#Eval("ImageId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField >
                    <ItemTemplate>
                        <asp:Button ID="btnEdit" CommandName="EmpEdit" CommandArgument='<%#Eval("EmployeeId") %>' runat="server" Text="Edit" />
                        <asp:Button ID="btnDelete" CommandName="EmpDlt" CommandArgument='<%#Eval("EmployeeId") %>' runat="server" Text="Delete" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        </td>
                  
                </tr>
                
            </table>
            
        </asp:Panel>
        
    </form>
</body>
</html>
