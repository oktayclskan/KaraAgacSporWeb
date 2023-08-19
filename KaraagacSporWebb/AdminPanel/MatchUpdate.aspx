<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/KaraagacSporAdmin.Master" AutoEventWireup="true" CodeBehind="MatchUpdate.aspx.cs" Inherits="KaraagacSporWebb.AdminPanel.MatchUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm-10">
                <div class="row">
                    <h1>Maç Güncelle</h1>
                    <asp:Panel ID="pnl_succes" runat="server" Visible="false">
                        <div class="alert alert-success" role="alert">
                            Başarıyla Güncellendi
                        </div>
                    </asp:Panel>
                    <asp:Panel ID="pnl_error" runat="server" Visible="false">
                        <div class="alert alert-danger" role="alert">
                            <asp:Label ID="lbl_eror" runat="server"></asp:Label>
                        </div>
                    </asp:Panel>
                    <div class="col">
                        <h4 class="mt-3 text-secondary">Takımının Skoru</h4>
                        <asp:TextBox ID="tb_myTeamSkor" CssClass="form-control mt-2" runat="server" placeholder="Baslik"></asp:TextBox>
                        <div>
                            <h4 class="mt-3 text-secondary">Karşı Takım Skor</h4>
                            <asp:TextBox ID="tb_opposingTeamSkor" TextMode="MultiLine" CssClass="form-control  mt-2 p-3" runat="server" placeholder="Özet" Height="100"></asp:TextBox>
                        </div>
                         <div>
                            <h4 class="mt-3 text-secondary">Karşı Takım Skor</h4>
                            <asp:TextBox ID="TextBox1" TextMode="MultiLine" CssClass="form-control  mt-2 p-3" runat="server" placeholder="Özet" Height="100"></asp:TextBox>
                        </div>
                        <div>
                            <div class="mb-3">
                                <asp:LinkButton ID="btn_matchUpdate" runat="server" CssClass="btn btn-success d-block mt-4"  >Güncelle</asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
