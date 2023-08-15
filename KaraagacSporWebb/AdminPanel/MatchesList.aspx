<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/KaraagacSporAdmin.Master" AutoEventWireup="true" CodeBehind="MatchesList.aspx.cs" Inherits="KaraagacSporWebb.AdminPanel.MatchesList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <h1>Maçlar 
        </h1>
        <a href="MatchesAdd.aspx" class="btn btn-lg bg-warning mt-2">Maç Ekle</a>
        <asp:ListView ID="lv_Matches" runat="server" OnItemCommand="lv_Matches_ItemCommand">
            <LayoutTemplate>
                <table class="table table-striped mt-5">
                    <tr>
                        <td>ID</td>
                        <td>Stadyum Adı</td>
                        <td class="text-center">Takım adı</td>
                        <td class="text-center">Karşı Takım Adı</td>
                        <td class="text-center">Skor</td>
                        <td class="text-center">Karşı Takım Skor</td>
                        <td class="text-center">Stadyum</td>
                        <td class="text-center">Resim 1</td>
                        <td class="text-center">Resim 2</td>
                        <td class="text-center">Resim 3</td>
                        <td class="text-center">Resim 4</td>
                        <td class="text-center">Resim 5</td>
                        <td class="text-center">Maç Tarihi</td>
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
                    <td class="text-center"><%# Eval("MyTeam") %></td>
                    <td class="text-center"><%# Eval("OppossingTeamName") %></td>
                    <td class="text-center"><%# Eval("MyTeamScore") %></td>
                    <td class="text-center"><%# Eval("OpposingTeamScore") %></td>
                    <td class="text-center"><%# Eval("StadiumOwnerStr") %></td>
                    <td class="text-center"><%# Eval("MatchDateTime") %></td>

                    <td>
                        <img src="Assets/Img/<%# Eval("ImgOne") %>" width="50" />
                    </td>
                     <td>
                        <img src="Assets/Img/<%# Eval("ImgTwo") %>" width="50" />
                    </td>
                     <td>
                        <img src="Assets/Img/<%# Eval("ImgThree") %>" width="50" />
                    </td>
                     <td>
                        <img src="Assets/Img/<%# Eval("ImgFour") %>" width="50" />
                    </td>
                     <td>
                        <img src="Assets/Img/<%# Eval("ImgFive") %>" width="50" />
                    </td>
                 
                    <td>
                        <a href="MatchUpdate.aspx?mid=<%# Eval("ID") %>" class="btn btn-success mt-4">Düzenle</a>
                    </td>
                    <td>
                        <asp:LinkButton ID="lbtn_dlt" runat="server" CssClass="btn btn-danger mt-4" CommandArgument='<%# Eval("ID") %>' CommandName="dlt">Sil</asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
