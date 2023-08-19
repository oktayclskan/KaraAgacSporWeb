<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/KaraagacSporAdmin.Master" AutoEventWireup="true" CodeBehind="MatchAdd.aspx.cs" Inherits="KaraagacSporWebb.AdminPanel.MatchAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-sm-10">
                <div class="row">
                    <h1>Maç Ekle</h1>
                    <asp:Panel ID="pnl_succes" runat="server" Visible="false">
                        <div class="alert alert-success" role="alert">
                            Başarıyla Eklendi
                        </div>
                    </asp:Panel>
                    <asp:Panel ID="pnl_error" runat="server" Visible="false">
                        <div class="alert alert-danger" role="alert">
                            <asp:Label ID="lbl_eror" runat="server"></asp:Label>
                        </div>
                    </asp:Panel>
                    <div class="col">
                        <div>
                            <label>Stadyum Seç</label><br />
                            <asp:DropDownList ID="dll_Stadium" runat="server" AppendDataBoundItems="true">
                                <asp:ListItem Text="Seçiniz" Value="0"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                          <div>
                            <label>Takım Seç</label><br />
                            <asp:DropDownList ID="dll_opposingTeam" runat="server" AppendDataBoundItems="true">
                                <asp:ListItem Text="Seçiniz" Value="0"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        
                        
                        <div>
                            <asp:TextBox ID="tb_myTeamScore" TextMode="Number" CssClass="form-control  mt-2" runat="server" placeholder="Takım Skor"></asp:TextBox>
                        </div>
                        <div>
                            <asp:TextBox ID="tb_opposingTeamScore" TextMode="Number" CssClass="form-control  mt-2" runat="server" placeholder="Karşı Takım Skor"></asp:TextBox>
                        </div>
                        <div class="mt-2">
                            <span>Ev Sahibimiyiz</span>
                            <asp:CheckBox ID="cb_StadiumOwner" runat="server" />
                        </div>
                         <div class="mt-2">
                            <asp:TextBox ID="tb_MatchDateTime" TextMode="DateTime" CssClass="form-control  mt-2" runat="server" placeholder="Maç Tarihi"></asp:TextBox>
                        </div>
                       
                       
                        <div>
                            <div class="mb-3 mt-2">
                                <asp:LinkButton ID="btn_matchAdd" runat="server" CssClass="btn btn-success d-block mt-4" OnClick="btn_matchAdd_Click">Ekle</asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
