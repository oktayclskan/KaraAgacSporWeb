<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="KaraagacSporWebb.AdminPanel.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Login</title>
    <link href="Assets/Css/AdminLogin.css" rel="stylesheet" />
    <link href="Assets/bootstrap-5.1.3-dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="Assets/fontawesome-free-6.3.0-web/css/all.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <div class="main mt-5">
                <h3 class="pt-2 pb-2 text-center text-white">Admin Giriş
                </h3>
                <img src="../Assets/images/karaagac-logo.png" width="150" class="mt-1" style="margin-left: 30%;" />
                <div class="row  m-lg-4">
                    <asp:Panel ID="pnl_error" runat="server" Visible="false">
                        <div class="alert alert-danger" role="alert">
                            <asp:Label ID="lbl_eror" runat="server">
                            </asp:Label>
                        </div>
                    </asp:Panel>
                    <div class="input-group mb-3 mt-2">
                         <asp:TextBox ID="tb_mail" runat="server" CssClass="form-control" Placeholder="E-mail"></asp:TextBox>
                    </div>
                    <div class="form-group mt-3">
                        <asp:TextBox ID="tb_password" runat="server" CssClass="form-control" Placeholder="Şifre" textmode="Password"></asp:TextBox>
                    </div>
                    <div class="form-group mt-3">
                        <asp:LinkButton ID="lbtn_Login" runat="server" CssClass="btn btn-success d-block mt-2" OnClick="lbtn_Login_Click">Giriş Yap</asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
        <script src="Assets/bootstrap-5.1.3-dist/js/bootstrap.bundle.min.js"></script>
        <script src="Assets/fontawesome-free-6.3.0-web/js/all.min.js"></script>
        <script src="Assets/bootstrap-5.1.3-dist/js/bootstrap.min.js"></script>
    </form>
</body>
</html>
