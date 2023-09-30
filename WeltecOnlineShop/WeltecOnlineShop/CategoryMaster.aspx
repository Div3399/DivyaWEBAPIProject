<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="CategoryMaster.aspx.cs" Inherits="WeltecOnlineShop.CategoryMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content-header">
        <div class="container-fluid">
            <div class="row mb-2">
                <div class="col-sm-6">
                    <h1>Category</h1>
                </div>
                <div class="col-sm-6">
                    <ol class="breadcrumb float-sm-right">
                        <a href="#">
                            <li class="breadcrumb-item ">Dashboard</li>
                        </a>
                        &nbsp;&nbsp;&nbsp;
                       <li class="breadcrumb-item active">Category</li>
                    </ol>
                </div>
            </div>
        </div>
        <!-- /.container-fluid -->
    </div>

    <section class="content">
        <div class="container-fluid">
            <div class="row">

                <div class="col-md-6">
                    <!-- Horizontal Form -->
                    <div class="card card-info">
                        <div class="card-header">
                            <h3 class="card-title">Category Matser</h3>
                        </div>
                        <!-- /.card-header -->
                            <div class="card-body">
                                <div class="form-group row">
                                    <label>Category Name</label>
                                    <asp:TextBox ID="txtcat" Class="form-control"  placeholder="Enter Category" runat="server"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="lblmsg" runat="server" cssclass="form-label" ForeColor="#ff0000"></asp:Label>
                                </div>
                            </div>
                            <!-- /.card-body -->
                            <div class="card-footer">
                                <asp:LinkButton ID="lnkbtnSave" class="btn btn-info" Width="80px" OnClick="lnkbtnSave_Click" runat="server">Save</asp:LinkButton>
                                <asp:LinkButton ID="lnkbtnCancel" class="btn btn-block bg-gradient-danger" Width="80px" OnClick="lnkbtnCancel_Click" runat="server">Cancel</asp:LinkButton>

                            </div>                    
                    </div>

                </div>



                <div class="col-md-6">
                    <div style="background-color: #17a2b8" class="card-header">
                        <h3 style="color: white" class="card-title">Category Matser Table</h3>
                    </div>
                    <!-- /.card-header -->
                    <div class="table-responsive">
                        <table id="" class="table table-bordered">
                            <tr>
                                <td>
                                    <asp:TextBox ID="txtSearch" Placeholder="Search for Categories" runat="server" OnTextChanged="txtSearch_TextChanged" AutoPostBack="true"></asp:TextBox>
                                    <asp:LinkButton ID="lnkbtnSearch" class="btn btn-block btn-secondary" Width="80px" OnClick="lnkbtnSearch_Click" runat="server">Seacrh</asp:LinkButton>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:GridView ID="GridCat" AutoGenerateColumns="false" PageSize="10" AllowPaging="true" OnPageIndexChanging="GridCat_PageIndexChanging"
                                        OnRowCommand="GridCat_RowCommand" runat="server">

                                        <Columns>
                                            <asp:TemplateField HeaderText="Sr NO.">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblSr" CssClass="form-label" runat="server" Text='<%#Container.DataItemIndex + 1 %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Category Id">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblCatId" CssClass="form-label" runat="server" Text='<%#Eval("CategoryId") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Category Name">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblCatName" CssClass="form-label" runat="server" Text='<%#Eval("CategoryName") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="IsActive">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblIsactive" CssClass="form-label" runat="server" Text='<%#Eval("IsActive") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Action">
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lnkbtnEdit" class="btn btn-info btn-sm"  CommandName="CatEdit" CommandArgument='<%#Eval("CategoryId") %>' runat="server"> <i class="fas fa-pencil-alt"></i> Edit</asp:LinkButton>
                                                    <asp:LinkButton ID="lnkbtnView" class="btn btn-primary btn-sm" CommandName="CatView" CommandArgument='<%#Eval("CategoryId") %>' runat="server"><i class="fas fa-folder"></i> View</asp:LinkButton>
                                                    <asp:LinkButton ID="lnkbtnDelete" class="btn btn-danger btn-sm" CommandName="CatDlt" CommandArgument='<%#Eval("CategoryId") %>' runat="server"><i class="fas fa-trash"></i>Delete</asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <!-- /.card-body -->
                </div>
            </div>
        </div>

        <!-- /.container-fluid -->
    </section>
    
</asp:Content>


