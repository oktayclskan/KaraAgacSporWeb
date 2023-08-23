<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/KaraagacSporAdmin.Master" AutoEventWireup="true" CodeBehind="MatchDetailList.aspx.cs" Inherits="KaraagacSporWebb.AdminPanel.MatchDetailList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>Maç Detayaları
        </h1>
        <a href="#" class="btn btn-lg bg-warning mt-2">Haber Ekle Ekle</a>
        <asp:ListView ID="lv_MatchDetail" runat="server" OnItemCommand="lv_MatchDetail_ItemCommand">
            <LayoutTemplate>
                <table class="table table-striped mt-5">
                    <tr>
                        <td>ID</td>
                        <td>Kart</td>
                        <td class="text-center">Takım Oyuncu</td>
                        <td class="text-center">Gol</td>
                        <td class="text-center">Yaşanan Dakkika</td>
                        <td class="text-center">Karşı Takım Oyuncu Adı</td>
                        <td class="text-center">Gol</td>
                        <td class="text-center">Yaşanan Dakkika</td>
                        <td colspan="2" class="text-center">Seçenekler</td>
                    </tr>
                    <tbody>
                        <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </tbody>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td class="p-2"><%# Eval("ID") %></td>
                    <td class="p-2"><%# Eval("CardName") %></td>
                    <td class="text-center"><%# Eval("PlayerName") %></td>
                    <td class="text-center"><%# Eval("MyTeamGoal") %></td>
                    <td class="text-center"><%# Eval("MyTeamTime") %></td>
                    <td class="text-center"><%# Eval("OpposingTeamPlayerName") %></td>
                    <td class="text-center"><%# Eval("OpposingTeamGoal") %></td>
                    <td class="text-center"><%# Eval("OpposingTeamTime") %></td>
                    <td>
                        <asp:LinkButton ID="lbtn_dlt" runat="server" CssClass="btn btn-danger mt-1" CommandArgument='<%# Eval("ID") %>' CommandName="dlt">Sil</asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>

    </div>
</asp:Content>
