<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/KaraagacSporAdmin.Master" AutoEventWireup="true" CodeBehind="NewsList.aspx.cs" Inherits="KaraagacSporWebb.AdminPanel.NewsList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>Haberler
        </h1>
        <a href="NewsAdd.aspx" class="btn btn-lg bg-warning mt-2">Haber Ekle Ekle</a>
        <asp:ListView ID="lv_News" runat="server" OnItemCommand="lv_News_ItemCommand">
            <LayoutTemplate>
                <table class="table table-striped mt-5">
                    <tr>
                        <td>ID</td>
                        <td>Başlık</td>
                        <td class="text-center">Özet</td>
                        <td class="text-center">İçerik</td>
                        <td class="text-center">Tarih</td>
                        <td class="text-center">Kart Resim</td>
                        <td class="text-center">İçerik Resim</td>
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
                    <td><%# Eval("NewsTitle") %></td>
                    <td class="text-center"><%# Eval("NewsDescription") %></td>
                    <td class="text-center"><%# Eval("NewsContent") %></td>
                    <td class="text-center"><%# Eval("NewsDateStr") %></td>
                    <td>
                        <img src="Assets/Img/<%# Eval("NewsCardImg") %>" width="100" />
                    </td>
                    <td>
                        <img src="Assets/Img/<%# Eval("NewsContentImg") %>" width="100" />
                    </td>
                    <td>
                        <a href='NewsUpdate.aspx?neid=<%#Eval("ID")%>' class="btn btn-success mt-5">Düzenle</a>
                    </td>
                    <td>
                        <asp:LinkButton ID="lbtn_dlt" runat="server" CssClass="btn btn-danger mt-5" CommandArgument='<%# Eval("ID") %>' CommandName="dlt">Sil</asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>

    </div>
</asp:Content>
