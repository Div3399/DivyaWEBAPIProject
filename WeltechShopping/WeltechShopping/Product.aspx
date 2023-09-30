<%@ Page Title="Product | Admin" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="WeltechShopping.Product" %>

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
                            <li class="breadcrumb-item">Dashboard /</li>
                        </a>
                        <li class="breadcrumb-item active">SubCategory </li>
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
                <div class="col-xl-12">
                    <!-- general form elements -->
                    <div class="card card-primary">
                        <div class="card-header">
                            <h3 class="card-title">Product Master</h3>
                        </div>
                        <!-- /.card-header -->
                        <div class="card-body">
                            <div class="form-group">
                                <asp:Label ID="LblMsg" runat="server" CssClass="form-label accent-danger"></asp:Label>
                            </div>
                            <div class="row">
                                <div class="col-xl-3">
                                    <div class="form-group">
                                        <label for="Category">Category</label>
                                        <asp:DropDownList ID="ddlCategory" runat="server" CssClass="dropdown form-control"></asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-xl-3">
                                    <div class="form-group">
                                        <label for="Subcategory">Subcategory</label>
                                        <asp:DropDownList ID="ddlSubcategory" runat="server" CssClass="dropdown form-control"></asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-xl-3">
                                    <div class="form-group">
                                        <label for="Brand">Brand</label>
                                        <asp:DropDownList ID="ddlBrand" runat="server" CssClass="dropdown form-control"></asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-xl-3">
                                    <div class="form-group">
                                        <label for="Color">Color</label>
                                        <asp:DropDownList ID="ddlColor" runat="server" CssClass="dropdown form-control"></asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xl-3">
                                    <div class="form-group">
                                        <label for="Offer">Offer</label>
                                        <asp:DropDownList ID="ddlOffer" runat="server" CssClass="dropdown form-control"></asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-xl-3">
                                    <div class="form-group">
                                        <label for="ProductName">Product Name</label>
                                        <asp:TextBox ID="txtProductName" runat="server" CssClass="form-control" placeholder="Enter Product Name"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-xl-3">
                                    <div class="form-group">
                                        <label for="ProductPrice">Product Price</label>
                                        <i class="fa fa-inr"></i>
                                        <asp:TextBox ID="txtProductPrice" runat="server" TextMode="Number" CssClass="form-control" placeholder="Enter Product Price"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-xl-3">
                                    <div class="form-group">
                                        <label for="ProductActualPrice</">Product Actual Price</label>
                                        <asp:TextBox ID="txtProductActualPrice" runat="server" TextMode="Number" CssClass="form-control" placeholder="Enter
                                    Product Actual Price"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xl-4">
                                    <div class="form-group">
                                        <label for="ProductSortDescription">Product Sort Description</label>
                                        <asp:TextBox ID="txtProductSortDescription" runat="server" CssClass="form-control" placeholder="Enter Product Sort Description" TextMode="MultiLine" Rows="2"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-xl-4">
                                    <div class="form-group">
                                        <label for="ProductLongDescription">Product Long Description</label>
                                        <asp:TextBox ID="txtProductLongDescription" runat="server" CssClass="form-control" placeholder="Enter Product Long Description" TextMode="MultiLine" Rows="4"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-xl-4">
                                    <div class="form-group">
                                        <label for="ProductTotalQuantity">Product Total Quantity</label>
                                        <asp:TextBox ID="txtProductTotalQuantity" runat="server" TextMode="Number" CssClass="form-control" placeholder="Enter Product Total Quantity"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xl-4">
                                    <div class="form-group">
                                        <label for="ProductImage">Product Image</label>
                                        <asp:FileUpload ID="fuProductImage" runat="server" CssClass="form-control" placeholder="Select Image" AllowMultiple="false" />
                                        <%--<label class="custom-file-label" for="fuProductImage">Choose file</label>--%>
                                        <asp:LinkButton ID="lnkbtnUpload" CssClass="m-1" runat="server" OnClick="lnkbtnUpload_Click">
                                            <span class="input-group-text">Upload</span>
                                        </asp:LinkButton>
                                        <%--<div class="input-group">
                                    <div class="custom-file">
                                        <input type="file" class="custom-file-input" id="exampleInputFile">

                                        <%--<asp:Button ID="btnUploadImg" runat="server" OnClick="btnUploadImg_Click" Text="Upload" />
                                    </div>
                                    <div class="input-group-append">
                                    </div>
                                </div>--%>
                                    </div>
                                </div>
                                <div class="col-xl-4">
                                    <div class="dz-image-preview m-2">
                                        <asp:Image ID="imgProductImage" runat="server" AlternateText="Product Image" CssClass="product-image-thumb" />
                                        <asp:Label ID="lblImg" runat="server"></asp:Label>
                                    </div>
                                </div>
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
                <div class="col-xl-12">
                    <!-- general form elements disabled -->
                    <div class="card card-primary">
                        <div class="card-header">
                            <h3 class="card-title">Product Master</h3>
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
                                            <asp:GridView ID="GVDisplay" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false" OnRowCommand="GVDisplay_RowCommand" PageSize="10" AllowPaging="true" OnPageIndexChanging="GVDisplay_PageIndexChanging">
                                                <Columns>
                                                    <asp:TemplateField HeaderText="Sr. No.">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblSrNo" runat="server" CssClass="form-label" Text='<%#Container.DataItemIndex + 1 %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Product Id">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblProductId" runat="server" CssClass="form-label" Text='<%#Eval("ProductId") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Category">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblCategory" runat="server" CssClass="form-label" Text='<%#Eval("CategoryName") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Subcategory">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblSubcategory" runat="server" CssClass="form-label" Text='<%#Eval("SubCatName") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Brand">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblBrand" runat="server" CssClass="form-label" Text='<%#Eval("BrandName") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Color">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblColor" runat="server" CssClass="form-label" Text='<%#Eval("ColorName") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Offer">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblOffer" runat="server" CssClass="form-label" Text='<%#Eval("OfferName") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Product Name">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblProductName" runat="server" CssClass="form-label" Text='<%#Eval("ProductName") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Product Price">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblProductPrice" runat="server" CssClass="form-label" Text='<%#Eval("ProductPrice") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Sort Description">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblProductSortDescription" runat="server" CssClass="form-label" Text='<%#Eval("SortDescription") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Long Description">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblProductLongDescription" runat="server" CssClass="form-label" Text='<%#Eval("LongDescription") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Total Quantity">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblProductTotalQuantity" runat="server" CssClass="form-label" Text='<%#Eval("TotalQuantity") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Actual Price">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblActualPrice" runat="server" CssClass="form-label" Text='<%#Eval("ActualPrice") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Product Image">
                                                        <ItemTemplate>
                                                            <asp:Image ID="imgProductImage" runat="server" AlternateText="Product Image" ImageUrl='<%#Eval("ProductImage") %>' CssClass="product-image-thumb" />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="IsActive">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblIsActive" runat="server" CssClass="form-label" Text='<%#Eval("IsActive") %>'></asp:Label>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Action">
                                                        <ItemTemplate>
                                                            <asp:LinkButton ID="btnEdit" runat="server" CssClass="btn btn-sm btn-info m-1" ToolTip="Edit" Text="Edit" role="Button" CommandArgument='<%#Eval("ProductId") %>' CommandName="EditProduct"><i class="fa fa-edit"></i></asp:LinkButton>
                                                            <asp:LinkButton ID="btnDelete" runat="server" ToolTip="Delete" Text="Delete" CssClass="btn btn-sm btn-danger" CommandArgument='<%#Eval("ProductId") %>' CommandName="DeleteProduct">
                                                                <i class="fa fa-trash"></i>
                                                            </asp:LinkButton>
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
    <!-- bs-custom-file-input -->
    <script src="App_Themes/plugins/bs-custom-file-input/bs-custom-file-input.min.js"></script>
</asp:Content>
