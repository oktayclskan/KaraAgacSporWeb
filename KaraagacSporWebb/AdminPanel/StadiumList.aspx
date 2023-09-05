<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/KaraagacSporAdmin.Master" AutoEventWireup="true" CodeBehind="StadiumList.aspx.cs" Inherits="KaraagacSporWebb.AdminPanel.StadiumList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>Stadyum Ayarları
        </h1>
        <a href="StadiumAdd.aspx" class="btn btn-lg bg-info mt-2">Stadyum Ekle</a>

        <asp:ListView ID="lv_stadiumList" runat="server" OnItemCommand="lv_stadiumList_ItemCommand">
            <LayoutTemplate>
                <table class="table table-striped mt-5">
                    <tr>
                        <td>ID</td>
                        <td>Stadyum İsmi</td>
                        <td class="text-center">Şehir</td>
                        <td class="text-center">İlçe</td>
                        <td class="text-center">Seçenekler</td>
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
                    <td style="text-align: center;"><%# Eval("StadiumCity") %></td>
                    <td style="text-align: center;"><%# Eval("StadiumDistrict") %></td>
                    <td class="text-center">
                        <asp:LinkButton ID="lbtn_dlt" runat="server" CssClass="btn btn-danger mt-2" CommandArgument='<%# Eval("ID") %>' CommandName="dlt">Sil</asp:LinkButton>
                    </td>

                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
