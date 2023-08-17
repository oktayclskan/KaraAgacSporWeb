<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/KaraagacSporAdmin.Master" AutoEventWireup="true" CodeBehind="PlayerUpdate.aspx.cs" Inherits="KaraagacSporWebb.AdminPanel.PlayerUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm-10">
                <div class="row">
                    <h1>Oyuncu Güncelle</h1>
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
                        <h4 class="mt-3 text-secondary">İsim</h4>
                        <asp:TextBox ID="tb_name" CssClass="form-control mt-2" runat="server" placeholder="İsim"></asp:TextBox>
                        <div>
                            <h4 class="mt-3 text-secondary">Soyisim</h4>
                            <asp:TextBox ID="tb_surname" TextMode="MultiLine" CssClass="form-control  mt-2" runat="server" placeholder="Soyisim"></asp:TextBox>
                        </div>
                         <div>
                             <h4 class="mt-3 text-secondary">Doğum Tarihi</h4>
                            <asp:TextBox ID="tb_dateOfBirth" TextMode="DateTime" CssClass="form-control  mt-2" runat="server" placeholder="Doğum Tarihi"></asp:TextBox>
                        </div>
                         <div>
                             <h4 class="mt-3 text-secondary">Forma Numarası</h4>
                            <asp:TextBox ID="tb_uniformNumber" TextMode="Number" CssClass="form-control  mt-2" runat="server" placeholder="Forma Numarası"></asp:TextBox>
                        </div>
                         <div>
                             <h4 class="mt-3 text-secondary">Mevki</h4>
                            <asp:TextBox ID="tb_position" CssClass="form-control  mt-2" runat="server" placeholder="Mevki"></asp:TextBox>
                        </div>
                         <div class="mt-3">

                             <asp:CheckBox ID="tb_firtEleven" CssClass="mt-2" runat="server" />
                             <span>İlk 11</span>

                        </div>
                         <div class="mt-3">
                             <asp:CheckBox ID="tb_status" CssClass="mt-2" runat="server" />
                             <span>Kadrodamı</span>
                        </div>
                        <div>
                            <div class="mb-3 mt-2">
                                <asp:Image ID="asp_img" runat="server" Width="150" />
                            </div>
                            <span>Resim seçiniz</span>
                            <asp:FileUpload ID="fu_img1" runat="server" CssClass="form-control form-control-sm" />
                            <div class="mb-3 mt-5">
                                <asp:LinkButton ID="btn_aboutUsUpdate" runat="server" CssClass="btn btn-success d-block" OnClick="btn_aboutUsUpdate_Click">Güncelle</asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
