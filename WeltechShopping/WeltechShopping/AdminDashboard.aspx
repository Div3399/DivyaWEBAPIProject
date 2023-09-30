<%@ Page Title="Dashboard-Admin-WeltechShoppin" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="WeltechShopping.AdminDashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderScript" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Content Header (Page header) -->
    <div class="content-header">
        <div class="container-fluid">
            <div class="row mb-2">
                <div class="col-sm-6">
                    <h1 class="m-0 text-dark">Dashboard</h1>
                </div>
                <!-- /.col -->
                <div class="col-sm-6">
                    <ol class="breadcrumb float-sm-right">
                        <%--<li class="breadcrumb-item"><a href="#"></a></li>--%>
                        <li class="breadcrumb-item active">Dashboard</li>
                    </ol>
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.container-fluid -->
    </div>
    <!-- /.content-header -->
    <section class="content">
        <div class="container-fluid">
            <!-- Small boxes (Stat box) -->
            <div class="row">
                <div class="col-lg-3 col-6">
                    <!-- small box -->
                    <a href="Category.aspx" class="small-box-footer">
                        <div class="small-box bg-info">
                            <div class="inner">
                                <h3>
                                    <asp:Label ID="lblTotCategory" CssClass="mx-3" runat="server"></asp:Label>
                                </h3>
                                <p>Categories</p>
                            </div>
                            <div class="icon">
                                <i class="ion ion-user"></i>
                            </div>
                            <div class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i></div>
                        </div>
                    </a>
                </div>
                <div class="col-lg-3 col-6">
                    <!-- small box -->
                    <a href="SubCategory.aspx" class="small-box-footer">
                        <div class="small-box bg-info">
                            <div class="inner">
                                <h3>
                                    <asp:Label ID="lblTotSubCategory" CssClass="mx-3" runat="server"></asp:Label>
                                </h3>
                                <p>SubCategories</p>
                            </div>
                            <div class="icon">
                                <i class="ion ion-user"></i>
                            </div>
                            <div class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i></div>
                        </div>
                    </a>
                </div>
                <div class="col-lg-3 col-6">
                    <!-- small box -->
                    <a href="Product.aspx" class="small-box-footer">
                        <div class="small-box bg-info">
                            <div class="inner">
                                <h3>
                                    <asp:Label ID="lblTotProducts" CssClass="mx-3" runat="server"></asp:Label>
                                </h3>
                                <p>Product</p>
                            </div>
                            <div class="icon">
                                <i class="ion ion-user"></i>
                            </div>
                            <div class="small-box-footer">More info <i class="fas fa-arrow-circle-right"></i></div>
                        </div>
                    </a>
                </div>
            </div>
        </div>
    </section>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="FooterScript" runat="server">
</asp:Content>
