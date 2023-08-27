<%@ Page Title="" Language="C#" MasterPageFile="~/KaraagacSporWebb.Master" AutoEventWireup="true" CodeBehind="players.aspx.cs" Inherits="KaraagacSporWebb.players" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="hero overlay" style="background-image: url('Assets/images/team-soccer-f.jpg');">
        <div class="container">
            <div class="row align-items-center">
                <div class="col-lg-5 mx-auto text-center">
                    <h1 class="text-white">Oyuncular</h1>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Soluta, molestias repudiandae pariatur.</p>
                </div>
            </div>
        </div>
    </div>

    <div class="site-section">
        <div class="container">
            <div class="row">
                <div class="col-6 title-section">
                    <h2 class="heading">Oyuncular /blog</h2>
                </div>
                <div class="col-6 text-right">
                    <div class="custom-nav">
                        <a href="#" class="js-custom-prev-v2"><span class="icon-keyboard_arrow_left"></span></a>
                        <span></span>
                        <a href="#" class="js-custom-next-v2"><span class="icon-keyboard_arrow_right"></span></a>
                    </div>
                </div>
            </div>
            <div class="owl-4-slider owl-carousel">


                <asp:Repeater ID="rp_players" runat="server">
                    <ItemTemplate>
                        <div class="item m-1">
                            <div class="video-media">
                                <img src="AdminPanel/Assets/Img/<%# Eval("PlayerImg") %>" alt="Image" class="img-fluid">
                                <a href="#" class="d-flex play-button align-items-center">
                                    <span class="icon mr-3">
                                        <span class="icon-play"></span>
                                    </span>
                                    <div class="caption">
                                        <span class="meta"><%# Eval("PlayerUniformNumber") %>/ <%# Eval("PlayerPosition") %></span>
                                        <h3 class="m-0"> <%# Eval("PlayerName") %> <%# Eval("PlayerSurname") %> </h3>
                                    </div>
                                </a>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>



    <%--<div class="container site-section">
        <div class="row">
            <div class="col-6 title-section">
                <h2 class="heading">Our Blog</h2>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-6">
                <div class="custom-media d-flex">
                    <div class="img mr-4">
                        <img src="Assets/images/img_1.jpg" alt="Image" class="img-fluid">
                    </div>
                    <div class="text">
                        <span class="meta">May 20, 2020</span>
                        <h3 class="mb-4"><a href="#">Romolu to stay at Real Nadrid?</a></h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus deserunt saepe tempora dolorem.</p>
                        <p><a href="#">Read more</a></p>
                    </div>
                </div>
            </div>
            <div class="col-lg-6">
                <div class="custom-media d-flex">
                    <div class="img mr-4">
                        <img src="Assets/images/img_3.jpg" alt="Image" class="img-fluid">
                    </div>
                    <div class="text">
                        <span class="meta">May 20, 2020</span>
                        <h3 class="mb-4"><a href="#">Romolu to stay at Real Nadrid?</a></h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus deserunt saepe tempora dolorem.</p>
                        <p><a href="#">Read more</a></p>
                    </div>
                </div>
            </div>
        </div>
    </div>--%>
</asp:Content>
