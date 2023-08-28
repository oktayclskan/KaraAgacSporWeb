<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/KaraagacSporAdmin.Master" AutoEventWireup="true" CodeBehind="OpposingTeamUpdate.aspx.cs" Inherits="KaraagacSporWebb.AdminPanel.OpposingTeamUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm-10">
                <div class="row">
                    <h1>Karşı Takım Bilgilerini Güncelle</h1>
                    <asp:Panel ID="pnl_succes" runat="server" Visible="false">
                        <div class="alert alert-success" role="alert">
                            Başarıyla güncellendi
                    
                        </div>
                    </asp:Panel>
                    <asp:Panel ID="pnl_error" runat="server" Visible="false">
                        <div class="alert alert-danger" role="alert">
                            <asp:Label ID="lbl_eror" runat="server"></asp:Label>
                        </div>
                    </asp:Panel>
                    <div class="col">
                        <h4 class="mt-3 text-secondary">Başlık</h4>
                        <asp:TextBox ID="tb_name" CssClass="form-control mt-2" runat="server" placeholder="Baslik"></asp:TextBox>
                        <div>
                            <div class="mb-3 mt-2">
                                <asp:Image ID="asp_img" runat="server" Width="150" />
                            </div>
                            <span>Resim seçiniz</span>
                            <asp:FileUpload ID="fu_img1" runat="server" CssClass="form-control form-control-sm" />
                        </div>
                        <div class="mb-3 mt-3">
                            <asp:LinkButton ID="btn_opposingTeamUpdt" runat="server" CssClass="btn btn-success d-block" OnClick="btn_opposingTeamUpdt_Click" >Güncelle</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
