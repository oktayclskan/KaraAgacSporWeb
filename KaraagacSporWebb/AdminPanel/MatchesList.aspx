<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/KaraagacSporAdmin.Master" AutoEventWireup="true" CodeBehind="MatchesList.aspx.cs" Inherits="KaraagacSporWebb.AdminPanel.MatchesList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>Maçlar 
        </h1>
        <a href="MatchAdd.aspx" class="btn btn-lg bg-warning mt-2">Maç Ekle</a>
        <asp:ListView ID="lv_Matches" runat="server" OnItemCommand="lv_Matches_ItemCommand">
            <LayoutTemplate>
                <table class="table table-striped mt-5">
                    <tr>
                        <td>ID</td>
                        <td>Stadyum Adı</td>
                        <td class="text-center">Karşı Takım logo</td>
                        <td class="text-center">Karşı Takım Adı</td>
                        <td class="text-center">Takım Logo</td>
                        <td class="text-center">Ev Sahibi</td>
                        <td class="text-center">Maç Tarihi</td>
                        <td class="text-center">Takım Skor</td>
                        <td class="text-center">Karşı takım Skor</td>
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
                    <td><%# Eval("StadiumName") %></td>
                    <td class="text-center">
                        <img src="Assets/Img/<%#Eval("OppesingTeamLogo") %>" width="50" />
                    </td>
                    <td class="text-center"><%# Eval("OpposingTeamName") %></td>

                    <td class="text-center">
                        <img src="../Assets/images/karaagac-logo.png" width="50" />
                    </td>
                    <td class="text-center"><%# Eval("StadiumOwnerStr") %></td>

                    <td class="text-center"><%# Eval("MatchDateTime") %></td>

                    <td class="text-center"><%# Eval("MyTeamScore") %></td>
                    <td class="text-center"><%# Eval("OpposingTeamScore") %></td>

                    
                    <td>
                        <asp:LinkButton ID="lbtn_dlt" runat="server" CssClass="btn btn-danger mt-3" CommandArgument='<%# Eval("ID") %>' CommandName="dlt">Sil</asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
