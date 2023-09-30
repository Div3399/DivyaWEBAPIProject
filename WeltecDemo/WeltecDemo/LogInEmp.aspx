<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogInEmp.aspx.cs" Inherits="WeltecDemo.LogInEmp" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>AdminLTE 3 | Log in (v2)</title>

    <!-- Google Font: Source Sans Pro -->
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&amp;display=fallback">
    <!-- Font Awesome -->
    <link rel="stylesheet" href="../../plugins/fontawesome-free/css/all.min.css">
    <!-- icheck bootstrap -->
    <link rel="stylesheet" href="../../plugins/icheck-bootstrap/icheck-bootstrap.min.css">
    <!-- Theme style -->
    <link rel="stylesheet" href="../../dist/css/adminlte.min.css">
</head>

<body class="login-page" style="min-height: 480px;">
    <form id="MyWebpage" runat="server">
        <div class="login-box">
            <!-- /.login-logo -->
            <div class="card card-outline card-primary">
                <div class="card-header text-center">
                    <a href="#" class="h1"><b>LogIn</b></a>
                </div>
                <div class="card-body">

                    <div class="input-group mb-3">
                        <label>Email ID</label>
                        <asp:TextBox ID="txtEmail" Width="270px" runat="server"></asp:TextBox>
                        <div class="input-group-append">
                            <div class="input-group-text">
                                <span class="fas fa-envelope"></span>

                            </div>
                        </div>
                    </div>

                    <div class="input-group mb-3">
                        <label>Username</label>
                        <asp:TextBox ID="txtUsername" Width="270px" runat="server"></asp:TextBox>
                        <div class="input-group-append">
                            <div class="input-group-text">
                                <span class="fas fa-envelope"></span>

                            </div>
                        </div>
                    </div>

                    <div class="input-group mb-3">
                        <label>Password</label>
                        <asp:TextBox ID="txtPswd" TextMode="Password" Width="270px" runat="server"></asp:TextBox>
                        <div class="input-group-append">
                            <div class="input-group-text">
                                <span class="fas fa-lock"></span>

                            </div>
                        </div>
                    </div>


                    <div class="row">
                        <div class="col-8">
                            <div class="icheck-primary">
                                <input type="checkbox" id="remember">
                                <label for="remember">
                                    Remember Me
                                </label>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-4">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                
                            <asp:LinkButton ID="btnLogin" OnClick="btnLogin_Click" class="btn btn-block bg-gradient-primary" runat="server">SignIn</asp:LinkButton>
                        </div>
                        <!-- /.col -->
                    </div>

                    <div class="row">
                        <div class="col-4">
                            <asp:Label ID="lblmsg" ForeColor="green" runat="server" Text=""></asp:Label>
                        </div>
                        <!-- /.col -->
                    </div>

                </div>
            </div>
        </div>
    </form>



    

</body>
</html>
