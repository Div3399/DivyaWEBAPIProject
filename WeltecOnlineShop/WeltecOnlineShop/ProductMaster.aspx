<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ProductMaster.aspx.cs" Inherits="WeltecOnlineShop.ProductMaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content-header">
        <div class="container-fluid">
            <div class="row mb-2">
                <div class="col-sm-6">
                    <h1>Product</h1>
                </div>
                <div class="col-sm-6">
                    <ol class="breadcrumb float-sm-right">
                        <a href="#">
                            <li class="breadcrumb-item ">Dashboard</li>
                        </a>
                        &nbsp;&nbsp;&nbsp;
                       <li class="breadcrumb-item active">Product </li>
                    </ol>
                </div>
            </div>
        </div>
        <!-- /.container-fluid -->
    </div>


    <section class="content">
        <div class="container-fluid">
            <div class="row">

                <div class="col-md-12">
                    <!-- Horizontal Form -->
                    <div class="card card-info">
                        <div class="card-header">
                            <h3 class="card-title">Product Matser</h3>
                        </div>
                        <!-- /.card-header -->
                        <div class="card-body">
                            <div class="card-body">


                                <div class="row">

                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label>Product Name </label>
                                            <asp:TextBox ID="txtProduct" Class="form-control" runat="server" placeholder=" Enter Name"></asp:TextBox>
                                        </div>
                                    </div>

                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label>Category</label>
                                            <asp:DropDownList ID="ddlCategory" CssClass="dropdown form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </div>

                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label>SubCategory</label>
                                            <asp:DropDownList ID="ddlSubcategory" CssClass="dropdown form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </div>


                                </div>


                                <div class="row">

                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label>Brand</label>
                                            <asp:DropDownList ID="ddlBrand" CssClass="dropdown form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </div>

                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label>Size</label>
                                            <asp:DropDownList ID="ddlsize" CssClass="dropdown form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </div>

                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label>Offer</label>
                                            <asp:DropDownList ID="ddlOffer" CssClass="dropdown form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </div>


                                </div>



                                <div class="row">

                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label>Color</label>
                                            <asp:DropDownList ID="ddlcolor" CssClass="dropdown form-control" runat="server"></asp:DropDownList>
                                        </div>
                                    </div>

                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label>Actul Price</label>
                                            <asp:TextBox ID="txtActulPr" TextMode="Number" Class="form-control" runat="server" placeholder="Enter Price"></asp:TextBox>
                                        </div>
                                    </div>

                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label>Price</label>
                                            <asp:TextBox ID="txtprice" TextMode="Number" Class="form-control" runat="server" placeholder="Enter Price"></asp:TextBox>
                                        </div>
                                    </div>


                                </div>


                                <div class="row">

                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label>Total Quantity</label>
                                            <asp:TextBox ID="txtqunatity" TextMode="Number" Class="form-control" runat="server" placeholder="Enter Qunatity"></asp:TextBox>
                                        </div>
                                    </div>

                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label>Short Description</label>
                                            <asp:TextBox ID="txtShortDes" TextMode="MultiLine" Rows="3" Class="form-control" runat="server"></asp:TextBox>
                                        </div>
                                    </div>

                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label>Long Description</label>
                                            <asp:TextBox ID="txtlongdes" TextMode="MultiLine" Rows="3" Class="form-control" runat="server"></asp:TextBox>
                                        </div>
                                    </div>


                                </div>

                                <div class="row">

                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <label>Product Image</label>

                                        </div>
                                    </div>

                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <asp:FileUpload ID="FileUpload1" runat="server" />
                                            <asp:Button ID="btnUpload" runat="server" Text="Upload" />
                                            <asp:Label ID="lblsub" runat="server" Text=""></asp:Label>
                                        </div>
                                    </div>

                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <asp:Image ID="Image1" runat="server" Height="100px" Width="335px" ImageUrl="" />
                                        </div>
                                    </div>
                                </div>

                                <div class="row">

                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <div class="card-footer" style="vertical-align: central">
                                                <asp:LinkButton ID="lnkbtnSubmit" class="btn btn-info" Width="80px" runat="server">Submit</asp:LinkButton>
                                                <asp:LinkButton ID="lnkbtncancel" class="btn btn-block bg-gradient-danger" Width="80px" runat="server">Cancel</asp:LinkButton>
                                            </div>
                                            <asp:Label ID="lblmsg" runat="server" Text="" ForeColor="DarkBlue"></asp:Label>
                                        </div>
                                    </div>

                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>


    </section>

</asp:Content>
