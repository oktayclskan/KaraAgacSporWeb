<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/KaraagacSporAdmin.Master" AutoEventWireup="true" CodeBehind="NextMatchAdd.aspx.cs" Inherits="KaraagacSporWebb.AdminPanel.NextMatchAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm-10">
                <div class="row">
                    <h1>Gelecek Maçı Ekle</h1>
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
                            <label>Stadyum Seç</label><br />
                            <asp:DropDownList ID="dll_Stadium" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Text="Seçiniz" Value="0"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="mt-3">
                            <label>Takım Seç</label><br />
                            <asp:DropDownList ID="dll_opposingTeam" CssClass="form-control" runat="server" AppendDataBoundItems="true">
                                <asp:ListItem Text="Seçiniz" Value="0"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                            <div class="mt-3">
                                <asp:TextBox ID="tb_date" TextMode="DateTime" CssClass="form-control  mt-2 mb-2" runat="server" placeholder="Tarih"></asp:TextBox>
                            </div>

                        <div class="mb-3">
                            <asp:LinkButton ID="btn_NextMatchAdd" runat="server" CssClass="btn btn-success d-block mt-2" OnClick="btn_NextMatchAdd_Click">Ekle</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
