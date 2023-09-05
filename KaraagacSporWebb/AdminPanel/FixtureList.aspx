<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/KaraagacSporAdmin.Master" AutoEventWireup="true" CodeBehind="FixtureList.aspx.cs" Inherits="KaraagacSporWebb.AdminPanel.FixtureList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">
    <h1>Puan Tablosu
    </h1>
    <a href="PointFixtureAdd.aspx" class="btn btn-lg bg-info mt-2">Puan Tablosuna Veri Ekle</a>
    <asp:ListView ID="lv_pointFixture" runat="server" OnItemCommand="lv_pointFixture_ItemCommand" >
        <LayoutTemplate>
            <table class="table table-striped mt-5">
                <tr>
                    <td>ID</td>
                    <td>Takım Adı</td>
                    <td >Galibiyet</td>
                    <td >Berabere</td>
                    <td >Mağlubiyet</td>
                    <td colspan="2" class="text-center" >Seçenekler</td>
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
                <td><%# Eval("Win") %></td>
                <td><%# Eval("Draw") %></td>
                <td><%# Eval("Lose") %></td>
                <td><%# Eval("Point") %></td>
                <td class="text-center">
                     <a href='PointFixtureUpdate.aspx?pfid=<%# Eval("ID") %>' class="btn btn-success mt-1">Düzenle</a>
                    <asp:LinkButton ID="lbtn_dlt" runat="server" CssClass="btn btn-danger mt-1" CommandArgument='<%# Eval("ID") %>' CommandName="dlt">Sil</asp:LinkButton>
                </td>
            </tr>
        </ItemTemplate>
    </asp:ListView>

</div>
</asp:Content>
