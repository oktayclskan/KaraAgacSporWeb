<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/KaraagacSporAdmin.Master" AutoEventWireup="true" CodeBehind="OpposingTeamList.aspx.cs" Inherits="KaraagacSporWebb.AdminPanel.OpposingTeamList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>Karşı Takım
        </h1>
        <a href="OpposingTeamAdd.aspx" class="btn btn-lg bg-info mt-2">Karşı Takım Ekle</a>
        <asp:ListView ID="lv_OpposingTeam" runat="server" OnItemCommand="lv_OpposingTeam_ItemCommand">
            <LayoutTemplate>
                <table class="table table-striped mt-5">
                    <tr>
                        <td>ID</td>
                        <td>Karşı Takım Adı</td>
                        <td class="text-center">Logo</td>
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
                    <td><%# Eval("Name") %></td>
                    <td style="text-align: center;">
                        <img src="Assets/Img/<%# Eval("Logo") %>" width="50" />
                    </td>
                    <td>
                        <a href="OpposingTeamUpdate.aspx?otid=<%# Eval("ID") %>" class="btn btn-success mt-3">Düzenle</a>
                    </td>
                   <%-- <td class="text-center">
                        <asp:LinkButton ID="lbtn_dlt" runat="server" CssClass="btn btn-danger mt-4" CommandArgument='<%# Eval("ID") %>' CommandName="dlt">Sil</asp:LinkButton>
                    </td>--%>
                </tr>
            </ItemTemplate>
        </asp:ListView>

    </div>
</asp:Content>
