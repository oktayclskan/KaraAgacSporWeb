<%@ Page Title="" Language="C#" MasterPageFile="~/KaraagacSporWebb.Master" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="KaraagacSporWebb.AboutUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="hero overlay" style="background-image: url('Assets/images/walpapaer.jpg');">
        <div class="container">
            <div class="row align-items-center">
                <div class="col-lg-5 mx-auto text-center">
                    <h1 class="text-white">Hakkımızda</h1>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Soluta, molestias repudiandae pariatur.</p>
                </div>
            </div>
        </div>
    </div>

    <div class="container site-section">
        <div class="row">
            <div class="col-12">
                <img src="Assets/images/2342997-48758710-2560-1440.jpg" />
            </div>
            <asp:Repeater ID="rp_aboutus" runat="server">
                <ItemTemplate>

                    <div class="col-md-10">
                        <h3><%# Eval("Title") %></h3>
                        <p><%# Eval("Content") %></p>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
