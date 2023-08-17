<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/KaraagacSporAdmin.Master" AutoEventWireup="true" CodeBehind="NewsAdd.aspx.cs" Inherits="KaraagacSporWebb.AdminPanel.NewsAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-sm-10">
                <div class="row">
                    <h1>Haber Ekle</h1>
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
                        <asp:TextBox ID="tb_title" CssClass="form-control mt-2" runat="server" placeholder="Baslik"></asp:TextBox>
                        <div>
                            <asp:TextBox ID="tb_description" TextMode="MultiLine" CssClass="form-control  mt-2" runat="server" placeholder="Özet"></asp:TextBox>
                        </div>
                        <div>
                            <asp:TextBox ID="tb_content" TextMode="MultiLine" CssClass="form-control  mt-2" runat="server" placeholder="içerik"></asp:TextBox>
                        </div>
                        <div>
                            <div class="mt-3">
                                <span>Kart Resmi Seçiniz</span>
                                <asp:FileUpload ID="fu_cardImg" runat="server" CssClass="form-control form-control-sm" />
                            </div>
                            <div class="mt-3">
                                <label class="form-label">İçerik Resimi Seciniz</label>
                                <asp:FileUpload ID="fu_ContentImg" runat="server" CssClass="form-control form-control-sm" />
                            </div>
                            <div class="mb-3">
                                <asp:LinkButton ID="btn_newssAdd" runat="server" CssClass="btn btn-success d-block mt-4" OnClick="btn_newssAdd_Click1" >Ekle</asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
