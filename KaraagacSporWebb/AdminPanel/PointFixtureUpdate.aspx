<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/KaraagacSporAdmin.Master" AutoEventWireup="true" CodeBehind="PointFixtureUpdate.aspx.cs" Inherits="KaraagacSporWebb.AdminPanel.PointFixtureUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm-10">
                <div class="row">
                    <h1>Puan Tablosu Güncelle</h1>
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
                        <div class="mt-3">
                            <h5 class="mt-2">Takım</h5>
                            <asp:DropDownList ID="dll_opposingTeam" CssClass="form-control" runat="server" AppendDataBoundItems="true">
                                <asp:ListItem Text="Seçiniz" Value="0"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <h5 class="mt-2">Galibiyet</h5>
                        <asp:TextBox ID="tb_win" CssClass="form-control mt-2" runat="server" placeholder="Galibiyet"></asp:TextBox>
                        <div>
                            <h5 class="mt-2">Beraberlik</h5>
                            <asp:TextBox ID="tb_Draw" CssClass="form-control  mt-2 " runat="server" placeholder="Beraberlik"></asp:TextBox>
                        </div>
                        <div>
                            <h5 class="mt-2">Mağlubiyet</h5>
                            <asp:TextBox ID="tb_lose" CssClass="form-control  mt-2" runat="server" placeholder="Mağlubiyet"></asp:TextBox>
                        </div>
                        <div>
                            <h5 class="mt-2">Puan</h5>
                            <asp:TextBox ID="tb_point" CssClass="form-control  mt-2" runat="server" placeholder="Puan"></asp:TextBox>
                        </div>
                        <div class="mb-3 mt-3">
                            <asp:LinkButton ID="btn_pointFixtureUpdate" runat="server" CssClass="btn btn-success d-block" OnClick="btn_pointFixtureUpdate_Click">Güncelle</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
