<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/KaraagacSporAdmin.Master" AutoEventWireup="true" CodeBehind="NextMatchList.aspx.cs" Inherits="KaraagacSporWebb.AdminPanel.NextMatchList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <h1>Yapılıcak Maç
        </h1>
        <a href="NextMatchAdd.aspx" class="btn btn-lg bg-warning mt-2">Gelecek Maçı Ekle</a>
        <asp:ListView ID="lv_NextMatch" runat="server" OnItemCommand="lv_NextMatch_ItemCommand">
            <LayoutTemplate>
                <table class="table table-striped mt-5">
                    <tr>
                        <td>ID</td>
                        <td>Stadyum Adı</td>
                        <td>Karşı Takım Adı</td>
                        <td class="text-center">Tarih</td>
                        <td>Seçenekler</td>
                    </tr>
                    <tbody>
                        <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </tbody>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td class="p-2"><%# Eval("ID") %></td>
                    <td><%# Eval("OpposingTeamName") %></td>
                    <td><%# Eval("StadiumName") %></td>
                    <td><%# Eval("Date") %></td>
               
                    <td>
                        <asp:LinkButton ID="lbtn_dlt" runat="server" CssClass="btn btn-danger mt-1" CommandArgument='<%# Eval("ID") %>' CommandName="dlt">Sil</asp:LinkButton>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>

    </div>
</asp:Content>
