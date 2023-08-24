<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/KaraagacSporAdmin.Master" AutoEventWireup="true" CodeBehind="OpposingTeamAdd.aspx.cs" Inherits="KaraagacSporWebb.AdminPanel.OpposingTeamAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm-10">
                <div class="row">
                    <h1>Karşı Takım Ekle</h1>
                    <asp:Panel ID="pnl_succes" runat="server" Visible="false">
                        <div class="alert alert-success" role="alert">
                            Başarıyla Eklendi
                        </div>
                    </asp:Panel>
                    <asp:Panel ID="pnl_error" runat="server" Visible="false">
                        <div class="alert alert-danger" role="alert">
                            <asp:Label ID="lbl_eror" runat="server"></asp:Label>
                        </div>
                    </asp:Panel>
                    <div class="col">
                        <div class="mt-3">
                            <asp:TextBox ID="tb_name" CssClass="form-control  mt-2 mb-2" runat="server" placeholder="Karşı Takım Adı"></asp:TextBox>
                        </div>
                        <div class="mt-2">
                            <span>Logo seçiniz</span>
                            <asp:FileUpload ID="fu_opposingImg" runat="server" CssClass="form-control form-control-sm" />
                        </div>

                        <div class="mb-3">
                            <asp:LinkButton ID="btn_opposingTeamAdd" runat="server" CssClass="btn btn-success d-block mt-2" OnClick="btn_opposingTeamAdd_Click">Ekle</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
