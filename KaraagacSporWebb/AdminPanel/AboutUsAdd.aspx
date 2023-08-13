<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/KaraagacSporAdmin.Master" AutoEventWireup="true" CodeBehind="AboutUsAdd.aspx.cs" Inherits="KaraagacSporWebb.AdminPanel.AboutUsAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm-10">
                <div class="row">
                    <h1>Ekle</h1>
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
                            <asp:TextBox ID="tb_content" TextMode="MultiLine" CssClass="form-control  mt-2" runat="server" placeholder="içerik"></asp:TextBox>
                        </div>
                        <div>
                           
                            <span>Resim seçiniz</span>
                            <asp:FileUpload ID="fu_img1" runat="server" CssClass="form-control form-control-sm" />
                            <div class="">
                                <label class="form-label">Resim Seciniz</label>
                                <asp:FileUpload ID="fu_img2" runat="server" CssClass="form-control form-control-sm" />
                            </div>

                            
                            <div class="mb-3">
                                <label class="form-label">Resim Seciniz</label>
                                <asp:FileUpload ID="fu_img3" runat="server" CssClass="form-control form-control-sm" />
                            </div>


                            <div class="mb-3">
                                <asp:LinkButton ID="btn_aboutUsAdd" runat="server" CssClass="btn btn-success d-block" OnClick="btn_aboutUsAdd_Click">Ekle</asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
