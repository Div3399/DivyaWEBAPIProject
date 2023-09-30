<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ThemeImple.aspx.cs" Inherits="WeltecDemo.ThemeImple" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Content Header (Page header) -->
    <div class="content-header">
        <div class="container-fluid">
            <div class="row mb-2">
                <div class="col-sm-6">
                    <h1 class="m-0 text-dark">REGISTRATION FORM</h1>
                </div>

            </div>
            <!-- /.row -->
        </div>
        <!-- /.container-fluid -->
    </div>

    <div class="card card-default">
        <asp:Panel ID="PanelADD" Visible="true" runat="server">
             <div class="card-body">
           

            <div class="row">

                <div class="col-md-4">
                    <div class="form-group">
                        <label>Employee no</label>
                        <asp:TextBox ID="txtEmpNo" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="col-md-4">
                    <div class="form-group">
                        <label>First Name</label>
                        <asp:TextBox ID="txtFname" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="col-md-4">
                    <div class="form-group">
                        <label>Last Name</label>
                        <asp:TextBox ID="txtlname" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>


            </div>


            <div class="row">

                <div class="col-md-4">
                    <div class="form-group">
                        <label>Gender</label>
                        <asp:RadioButtonList ID="rdbtn" RepeatDirection="Horizontal" runat="server">
                            <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                            <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                </div>

                <div class="col-md-4">
                    <div class="form-group">
                        <label>Birth Date</label>
                        <div class="input-group-prepend">
                            <span class="input-group-text"><i class="far fa-calendar-alt"></i></span>
                            <asp:TextBox ID="txtBirth" TextMode="Date" Class="form-control" runat="server"></asp:TextBox>
                        </div>

                    </div>
                </div>

                <div class="col-md-4">
                    <div class="form-group">
                        <label>Joining date</label>
                        <div class="input-group-prepend">
                            <span class="input-group-text"><i class="far fa-calendar-alt"></i></span>
                            <asp:TextBox ID="txtjoining" TextMode="Date" Class="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>


            </div>



            <div class="row">

                <div class="col-md-4">
                    <div class="form-group">
                        <label>Mobile No</label>
                        <div class="input-group-prepend">
                            <span class="input-group-text"><i class="fas fa-phone"></i></span>
                            <asp:TextBox ID="txtMobile" class="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="col-md-4">
                    <div class="form-group">
                        <label>Home No</label>
                        <div class="input-group-prepend">
                            <span class="input-group-text"><i class="fas fa-phone"></i></span>
                            <asp:TextBox ID="txtHoMoNo" class="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="col-md-4">
                    <div class="form-group">
                        <label>Address</label>
                        <br />
                        <asp:TextBox ID="txtCuAdd" TextMode="MultiLine" Width="390px" runat="server"></asp:TextBox>
                    </div>
                </div>


            </div>


            <div class="row">

                <div class="col-md-4">
                    <div class="form-group">
                        <label>Email Address</label>
                        <asp:TextBox ID="txtemailId" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="col-md-4">
                    <div class="form-group">
                        <label>Branch</label>
                        <asp:DropDownList ID="ddlBranch" class="form-control" runat="server"></asp:DropDownList>
                    </div>
                </div>

                <div class="col-md-4">
                    <div class="form-group">
                        <label>Role</label>
                        <asp:DropDownList ID="ddlRole" class="form-control" runat="server"></asp:DropDownList>
                    </div>
                </div>


            </div>


            <div class="row">

                <div class="col-md-4">
                    <div class="form-group">
                        <label>Hobbies</label>
                    </div>
                </div>

                <div class="col-md-4">
                    <div class="form-group">                      
                         <asp:CheckBoxList ID="ChckHobbies" RepeatDirection="vertical"  runat="server"></asp:CheckBoxList>
                    </div>
                </div>

            </div>

            <div class="row">

                <div class="col-md-4">
                    <div class="form-group">
                        <label>Employee Photo</label>
                    </div>
                </div>

                <div class="col-md-4">
                    <div class="form-group">
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                        <asp:Button ID="BtnUpload" OnClick="BtnUpload_Click" runat="server" Text="Upload Image" />
                        <asp:Label ID="lblImg" runat="server" Text=""></asp:Label>
                    </div>
                </div>

                <div class="col-md-4">
                    <div class="form-group">
                        <asp:Image ID="Image1" runat="server" Height="100px" Width="335px" ImageUrl="~/Image" />
                    </div>
                </div>


            </div>

            <div class="row">

                <div class="col-md-4">
                    <div class="form-group">
                        <label>Documents</label>
                    </div>
                </div>

                <div class="col-md-4">
                    <div class="form-group">
                        <asp:FileUpload ID="FileUpload2" runat="server" />
                        <asp:Button ID="BtnDoc" OnClick="BtnDoc_Click" Width="125px" runat="server" Text="UploadDocument" />
                        <asp:Label ID="lbldoc" runat="server" Text=""></asp:Label>
                    </div>
                </div>

                <div class="col-md-4">
                    <div class="form-group">
                        <asp:Image ID="Image2" runat="server" Height="100px" Width="335px" ImageUrl="~/Documents" />
                    </div>
                </div>


            </div>


            <div class="row">

                <div class="col-md-4">
                    <div class="form-group">
                        <div class="card-footer">
                            <asp:Button ID="btnSubmit" class="btn btn-primary" OnClick="btnSubmit_Click" runat="server" Text="Submit" />
                        </div>
                        <asp:Label ID="lblmsg" runat="server" Text="" ForeColor="DarkBlue"></asp:Label>
                    </div>
                </div>

            </div>

        </div>
        </asp:Panel>  
       

        <asp:Panel ID="Panellist" Visible="false" runat="server">
            <div class="card-body">   
        <div class="row">
            <div class="col-sm-12">
                <table style= width: "100%"; class="table table-bordered table-striped dataTable dtr-inline">
                    <tr>
                        <td><asp:Button ID="btnSearch" OnClick="btnSearch_Click" runat="server" Text="Seacrh" />
                            <asp:TextBox ID="txtSearch" OntextChanged="txtSearch_TextChanged" AutoPostBack="true" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:GridView ID="EmpDetails" AutoGenerateColumns="false" Pagesize="5" AllowPaging="true" OnPageIndexChanging="EmpDetails_PageIndexChanging" 
                              OnRowCommand="EmpDetails_RowCommand"  runat="server">
                                <Columns>
                                    <asp:TemplateField HeaderText="Sr No">
                                        <ItemTemplate>
                                            <asp:Label ID="lblSrNo" runat="server" Text='<%#Container.DataItemIndex + 1 %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="EmployeeNo">
                                        <ItemTemplate>
                                            <asp:Label ID="lblEmployeeNo" runat="server" Text='<%#Eval("EmployeeNo") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="First Name">
                                        <ItemTemplate>
                                            <asp:Label ID="lblFname" runat="server" Text='<%#Eval("FirstName") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Last Name">
                                        <ItemTemplate>
                                            <asp:Label ID="lblLname" runat="server" Text='<%#Eval("LastName") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText=" Gender">
                                        <ItemTemplate>
                                            <asp:Label ID="lblGender" runat="server" Text='<%#Eval("Gender") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText=" BirthDate">
                                        <ItemTemplate>
                                            <asp:Label ID="lblBOD" runat="server" Text='<%#Eval("BirthDate") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText=" MobileNo.">
                                        <ItemTemplate>
                                            <asp:Label ID="lblMObNo" runat="server" Text='<%#Eval("MobileNo") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText=" HomeMob No">
                                        <ItemTemplate>
                                            <asp:Label ID="lblHomeMob" runat="server" Text='<%#Eval("HomeMObileNo") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText=" Email Id">
                                        <ItemTemplate>
                                            <asp:Label ID="lblEmail" runat="server" Text='<%#Eval("EmailId") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText=" Address">
                                        <ItemTemplate>
                                            <asp:Label ID="lblCurrentAdd" runat="server" Text='<%#Eval("Address") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText=" Joining Date">
                                        <ItemTemplate>
                                            <asp:Label ID="lbljoiningdate" runat="server" Text='<%#Eval("JoiningDate") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                     <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="btnEdit" class="btn btn-block bg-gradient-primary" CommandName="EmpEdit" CommandArgument='<%#Eval("EmployeeId") %>' runat="server">EDIT</asp:LinkButton>
                                             <asp:LinkButton ID="btnDelete" class="btn btn-block btn-danger" CommandName="EmpDlt" CommandArgument='<%#Eval("EmployeeId") %>' runat="server">DELETE</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                </Columns>
                            </asp:GridView>
                        </td>
                       
                    </tr>
                    
                </table>
            </div>
        </div>


        <div class="row">
            <div class="col-sm-12 col-md-5">
                <div class="dataTables_info" id="example1_info" role="status" aria-live="polite">Showing 1 to 10 entries</div>
            </div>


    </div>


        </div>
        </asp:Panel>
         
    </div>

  


  
   

     


</asp:Content>
