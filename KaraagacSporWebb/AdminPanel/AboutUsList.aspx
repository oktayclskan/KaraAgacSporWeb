<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/KaraagacSporAdmin.Master" AutoEventWireup="true" CodeBehind="AboutUsList.aspx.cs" Inherits="KaraagacSporWebb.AdminPanel.AboutUsList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>Hakkımızda
        </h1>
        <a href="AboutUsAdd.aspx" class="btn btn-lg bg-warning mt-2">Bilgi Ekle</a>
          <asp:ListView ID="lv_AboutUs" runat="server" OnItemCommand="lv_AboutUs_ItemCommand" >
                <LayoutTemplate>
                    <table class="table table-striped mt-5">
                        <tr>
                            <td>ID</td>
                            <td>Başlık</td>
                            <td class="text-center">İçerik</td>
                            <td class="text-center">Resim</td>
                            <td colspan="4" class="text-center">Seçenekler</td>
                        </tr>
                        <tbody>
                            <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
                        </tbody>
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr>
                        <td class="p-2"><%# Eval("ID") %></td>
                        <td><%# Eval("Title") %></td>
                        <td style="text-align: center;"><%# Eval("Content") %></td>
                        <td>
                            <img src="Assets/Img/<%# Eval("Img") %>" width="80" class="mt-3" />
                        </td>
                        <td>
                            <img src="Assets/Img/<%# Eval("Img2") %>" width="80" class="mt-3"/>

                        </td>
                        <td>
                            <img src="Assets/Img/<%# Eval("Img3") %>" width="80" class="mt-3"/>

                        </td>
                        <td>
                            <a href="AboutUsUpdate.aspx?aid=<%# Eval("ID") %>"class="btn btn-success mt-4">Düzenle</a>
                        </td>
                        <td>
                            <asp:LinkButton ID="lbtn_dlt" runat="server" CssClass="btn btn-danger mt-4" CommandArgument='<%# Eval("ID") %>' CommandName="dlt">Sil</asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
       
    </div>
</asp:Content>
