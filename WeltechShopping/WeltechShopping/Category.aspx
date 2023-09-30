<%@ Page Title="Category - Admin-WeltechShoppin" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="WeltechShopping.Category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderScript" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="content-header">
        <div class="container-fluid">
            <div class="row mb-2">
                <div class="col-sm-6">
                    <h1 class="m-0 text-dark">Dashboard</h1>
                </div>
                <!-- /.col -->
                <div class="col-sm-6">
                    <ol class="breadcrumb float-sm-right">
                        <a href="AdminDashboard.aspx">
                            <li class="breadcrumb-item">Dashboard</li>
                        </a>
                        <li class="breadcrumb-item active">Category</li>
                    </ol>
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.container-fluid -->
    </div>

    <section class="content">
        <div class="container-fluid">
            <div class="row">
                <!-- left column -->
                <div class="col-md-6">
                    <!-- general form elements -->
                    <div class="card card-primary">
                        <div class="card-header">
                            <h3 class="card-title">Category Master</h3>
                        </div>
                        <!-- /.card-header -->
                        <div class="card-body">
                            <div class="form-group">
                                <asp:Label ID="LblMsg" runat="server" CssClass="form-label"></asp:Label>
                            </div>
                            <div class="form-group">
                                <label for="CategoryName">Category Name</label>
                                <asp:TextBox ID="txtCatName" runat="server" CssClass="form-control" placeholder="Enter Category Name"></asp:TextBox>
                            </div>
                        </div>
                        <!-- /.card-body -->
                        <div class="card-footer">
                            <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary" OnClick="btnSave_Click" Text="Save" />
                            <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-primary" OnClick="btnCancel_Click" Text="Cancel" />
                        </div>
                    </div>
                </div>
                <!--/.col (left) -->
                <!-- right column -->
                <div class="col-md-6">
                    <!-- general form elements disabled -->
                    <div class="card card-primary">
                        <div class="card-header">
                            <h3 class="card-title">Category Master</h3>
                        </div>
                        <!-- /.card-header -->
                        <div class="card-body">
                            <div class="table-responsive">
                                <table id="" class="table table-bordered">
                                    <tr>
                                        <td>
                                            <asp:TextBox ID="txtSearchTerm" runat="server" CssClass="form-control" OnTextChanged="txtSearchTerm_TextChanged" placeholder="Search Here" AutoPostBack="true"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:LinkButton ID="lnkbtnClear" runat="server" CssClass="btn btn-primary" Text="Clear" OnClick="lnkbtnClear_Click">
                                            <i class="fa fa-times"></i>
                                            </asp:LinkButton>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:GridView ID="GVCateforyDisplay" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false" OnRowCommand="GVCateforyDisplay_RowCommand" PageSize="10" AllowPaging="true" OnPageIndexChanging="GVCateforyDisplay_PageIndexChanging">
                                                <Columns>
                                                    <asp:TemplateField HeaderText="Sr. No.">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblSrNo" runat="server" CssClass="form-label" Text='<%#Container.DataItemIndex + 1 %>'>
                                                            </asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Category Id">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblCategoryId" runat="server" CssClass="form-label" Text='<%#Eval("CategoryId") %>'>
                                                            </asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Category Name">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblCategoryName" runat="server" CssClass="form-label" Text='<%#Eval("CategoryName") %>'>
                                                            </asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="IsActive">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblIsActive" runat="server" CssClass="form-label" Text='<%#Eval("IsActive") %>'>
                                                            </asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Action">
                                                        <ItemTemplate>
                                                            <asp:LinkButton ID="btnEdit" runat="server" CssClass="btn btn-sm btn-info m-1" ToolTip="Edit" Text="Edit" role="Button" CommandArgument='<%#Eval("CategoryId") %>' CommandName="EditCategory"><i class="fa fa-edit"></i> </asp:LinkButton>
                                                            <asp:LinkButton ID="btnDelete" runat="server" ToolTip="Delete" Text="Delete" CssClass="btn btn-sm btn-danger" CommandArgument='<%#Eval("CategoryId") %>' CommandName="DeleteCategory">
                                            <i class="fa fa-trash"></i>
                                                            </asp:LinkButton>
                                                            <%--<asp:LinkButton ID="btnView" runat="server" CssClass="btn btn-dark" ToolTip="View" Text="View" CommandArgument='<%#Eval("CategoryId") %>' CommandName="ViewCategory">
                                             <i class="fa fa-eye"></i>
                                                            </asp:LinkButton>--%>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                </Columns>
                                            </asp:GridView>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                        <!-- /.card-body -->
                    </div>
                    <!-- /.card -->
                </div>
                <!--/.col (right) -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.container-fluid -->
    </section>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterScript" runat="server">
</asp:Content>
