<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/KaraagacSporAdmin.Master" AutoEventWireup="true" CodeBehind="PlayerList.aspx.cs" Inherits="KaraagacSporWebb.AdminPanel.PlayerList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="container">
        <h1>Oyuncular
        </h1>
        <a href="PlayerAdd.aspx" class="btn btn-lg bg-warning mt-2">Oyuncu Ekle</a>
        <asp:ListView ID="lv_Players" runat="server" OnItemCommand="lv_Players_ItemCommand">
            <LayoutTemplate>
                <table class="table table-striped mt-5">
                    <tr>
                        <td>ID</td>
                        <td>İsim</td>
                        <td class="text-center">Soyisim</td>
                        <td class="text-center">Doğum Tarihi</td>
                        <td class="text-center">Forma Numarası</td>
                        <td class="text-center">Mevki</td>
                        <td class="text-center">İlk 11</td>
                        <td class="text-center">Kadrodamı</td>
                        <td class="text-center">Resim</td>
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
                    <td><%# Eval("PlayerName") %></td>
                    <td class="text-center"><%# Eval("PlayerSurname") %></td>
                    <td class="text-center"><%# Eval("PlayerDateOfBirthStr") %></td>
                    <td class="text-center"><%# Eval("PlayerUniformNumber") %></td>
                    <td class="text-center"><%# Eval("PlayerPosition") %></td>
                    <td class="text-center"><%# Eval("PlayerStatusPlayer") %></td>
                    <td class="text-center"><%# Eval("PlayerStatusPlayerStr") %></td>
                    <td>
                        <img src="Assets/Img/<%# Eval("PlayerImg") %>" width="100" />
                    </td>
                    <td>
                        <a href="PlayerUpdate.aspx?pid=<%# Eval("ID") %>" class="btn btn-success mt-2">Düzenle</a>
                    </td>
                    <td>
                        <asp:LinkButton ID="lbtn_dlt" runat="server" CssClass="btn btn-danger mt-2" CommandArgument='<%# Eval("ID") %>' CommandName="dlt">Sil</asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>

    </div>
   

</asp:Content>
