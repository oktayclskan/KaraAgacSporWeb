<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/KaraagacSporAdmin.Master" AutoEventWireup="true" CodeBehind="AboutUsAdd.aspx.cs" Inherits="KaraagacSporWebb.AdminPanel.AboutUsAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row mt-5">
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
                            <div class="mb-3 mt-2">
                                <asp:LinkButton ID="btn_aboutUsAdd" runat="server" CssClass="btn btn-success d-block" OnClick="btn_aboutUsAdd_Click">Ekle</asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
