<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/KaraagacSporAdmin.Master" AutoEventWireup="true" CodeBehind="PlayerAdd.aspx.cs" Inherits="KaraagacSporWebb.AdminPanel.PlayerAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="container">
        <div class="row">
            <div class="col-sm-10">
                <div class="row">
                    <h1>Oyuncu Ekle</h1>
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
                        <asp:TextBox ID="tb_name" CssClass="form-control mt-2" runat="server" placeholder="İsim"></asp:TextBox>
                        <div>
                            <asp:TextBox ID="tb_surname" CssClass="form-control  mt-2" runat="server" placeholder="Soyisim"></asp:TextBox>
                        </div>
                        <div>
                                <div class="col-2 mt-2">
                                    <div class="input-group date">
                                        <asp:TextBox ID="tb_dateOfBirth" CssClass="form-control" TextMode="Date" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                        </div>
                        <div>
                            <asp:TextBox ID="tb_uniformNumber" TextMode="Number" CssClass="form-control mt-2" runat="server" placeholder="Forma Numarası"></asp:TextBox>
                        </div>
                        <div>
                            <asp:TextBox ID="tb_position" CssClass="form-control  mt-2" runat="server" placeholder="Mevki"></asp:TextBox>
                        </div>
                        <div class="mt-2">
                            <asp:CheckBox ID="cb_firstEleven" CssClass="mt-2" runat="server" />
                            <span>İlk 11</span>
                        </div>
                        <div class="mt-2">
                            <asp:CheckBox ID="cb_playerStatus" CssClass="mt-2" runat="server" />
                            <span>Kadrodamı</span>
                        </div>
                        <div>
                            <div class="mt-2">
                                <span>Resim seçiniz</span>
                                <asp:FileUpload ID="fu_img" runat="server" CssClass="form-control form-control-sm" />
                            </div>

                            <div class="mb-3 mt-3">
                                <asp:LinkButton ID="btn_PlayerAdd" runat="server" CssClass="btn btn-success d-block" OnClick="btn_PlayerAdd_Click">Ekle</asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
     <style>
        .input-group-append {
            cursor: pointer;
        }
    </style>
    <script>$(function () {
            $('#datepicker').datepicker();
        });</script>
</asp:Content>
