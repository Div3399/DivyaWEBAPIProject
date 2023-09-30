<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="SubCategoryMaster.aspx.cs" Inherits="WeltecOnlineShop.SubCategoryMaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content-header">
        <div class="container-fluid">
            <div class="row mb-2">
                <div class="col-sm-6">
                    <h1>Subcategory</h1>
                </div>
                <div class="col-sm-6">
                    <ol class="breadcrumb float-sm-right">
                        <a href="#">
                            <li class="breadcrumb-item ">Dashboard</li>
                        </a>
                        &nbsp;&nbsp;&nbsp;
                       <li class="breadcrumb-item active">SubCategory</li>
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
                            <h3 class="card-title">SubCategory Matser</h3>
                        </div>
                        <!-- /.card-header -->
                            <div class="card-body">

                                 <div class="form-group row">
                                    <label>Category Name</label>
                                    <asp:DropDownList ID="ddlCategoryName" Class="form-control" runat="server"></asp:DropDownList>
                                </div>

                                <div class="form-group row">
                                    <label>SubCategory Name</label>
                                    <asp:TextBox ID="txtSubCatName" Class="form-control"  placeholder="Enter SubCategory Name" runat="server"></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <asp:Label ID="lblmsg" runat="server" cssclass="form-label" ForeColor="#ff0000"></asp:Label>
                                </div>
                            </div>
                            <!-- /.card-body -->
                            <div class="card-footer">
                                <asp:LinkButton ID="lnkbtnSave"  class="btn btn-info" Width="80px" OnClick="lnkbtnSave_Click"  runat="server">Save</asp:LinkButton>
                                <asp:LinkButton ID="lnkbtnCancel" class="btn btn-block bg-gradient-danger" Width="80px" OnClick="lnkbtnCancel_Click" runat="server">Cancel</asp:LinkButton>
                            </div>                    
                    </div>

                </div>



                <div class="col-md-6">
                    <div style="background-color: #17a2b8" class="card-header">
                        <h3 style="color: white" class="card-title">SubCategory Matser Table</h3>
                    </div>
                    <!-- /.card-header -->
                    <div class="table-responsive">
                        <table id="" class="table table-bordered">
                            <tr>
                                <td>
                                    <asp:TextBox ID="txtSearch" placeholder="Search Here" OnTextChanged="txtSearch_TextChanged" AutoPostBack="true" runat="server"></asp:TextBox>
                                    <asp:LinkButton ID="lnkbtnSearch" class="btn btn-block btn-secondary" Width="80px" OnClick="lnkbtnSearch_Click" runat="server">Search</asp:LinkButton>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:GridView ID="GridviewSubcategory" AutoGenerateColumns="false" PageSize="10" AllowPaging="true" OnPageIndexChanging="GridviewSubcategory_PageIndexChanging"
                                       OnRowCommand="GridviewSubcategory_RowCommand" runat="server">

                                        <Columns>
                                            <asp:TemplateField HeaderText="Sr NO.">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblSr" CssClass="form-label" runat="server" Text='<%#Container.DataItemIndex + 1 %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="SubCategory Id">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblSubcatId" CssClass="form-label" runat="server" Text='<%#Eval("SubcategoryId") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="SubCategory Name">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblSubcatname" CssClass="form-label" runat="server" Text='<%#Eval("SubcategroyName")%>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                             <asp:TemplateField HeaderText="Category Name">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblcatname" CssClass="form-label" runat="server" Text='<%#Eval("CategoryId") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>


                                            <asp:TemplateField HeaderText="IsActive">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblIsactive" CssClass="form-label" runat="server" Text='<%#Eval("IsActive") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Action">
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lnkbtnEdit" class="btn btn-info btn-sm" CommandName="SubcatEdit" CommandArgument='<%#Eval("SubcategoryId") %>'  runat="server"><i class="fas fa-pencil-alt"></i> Edit</asp:LinkButton>
                                                    <asp:LinkButton ID="lnkbtnDelete" class="btn btn-danger btn-sm" CommandName="SubcatDelete" CommandArgument='<%#Eval("SubcategoryId") %>' runat="server"><i class="fas fa-trash"></i> Delete</asp:LinkButton>
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
