<%@ Page Title="" Language="C#" MasterPageFile="~/KaraagacSporWebb.Master" AutoEventWireup="true" CodeBehind="matches.aspx.cs" Inherits="KaraagacSporWebb.matches" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="hero overlay" style="background-image: url('Assets/images/bg_3.jpg');">
        <div class="container">
            <div class="row align-items-center">
                <div class="col-lg-5 mx-auto text-center">
                    <h1 class="text-white">Maçlar</h1>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Soluta, molestias repudiandae pariatur.</p>
                </div>
            </div>
        </div>
    </div>



    <div class="container">
      <%--  <div class="d-flex team-vs">

            <div class="row mt-5">
                <div class="col-lg-12 mt-5">
                    <div class="d-flex team-vs">
                        <div class="team-1 w-50">
                            <div class="team-details w-100 text-center">
                                <img src="Assets/images/<%# Eval("OpposingTeamLogo") %>" alt="Image" class="img-fluid">
                                <h3><%# Eval("MyTeam") %></h3>
                                <ul class="list-unstyled">
                                    <li><%# Eval("PlayerName") %> ( <%# Eval("MatchDetailTime") %> )</li>
                                </ul>
                            </div>
                        </div>
                        <div class="team-2 w-50">
                            <div class="team-details w-100 text-center">
                                <img src="Assets/images/<%# Eval("OpposingTeamLogo") %>" alt="Image" class="img-fluid">
                                <h3><%# Eval("OpposingTeamName") %></h3>
                                <ul class="list-unstyled">
                                    <li><%# Eval("PlayerName") %> ( <%# Eval("MatchDetailTime") %> )</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>--%>





        <div class="row mt-5">
            <asp:Repeater ID="rp_matches" runat="server">
                <ItemTemplate>
                    <div class="col-lg-12 mt-5">
                        <div class="d-flex team-vs mt-4">
                            <span class="score"><%#Eval("MyTeamScore") %>-<%#Eval("OpposingTeamScore") %></span>
                            <div class="team-1 w-50">
                                <div class="team-details w-100 text-center">
                                    <img src="Assets/images/karaagac-logo.png" alt="Image" class="img-fluid">
                                    <h3><%# Eval("MyTeam") %></h3>
                                    <ul class="list-unstyled">
                                        <li><%# Eval("PlayerName") %> ( <%# Eval("MatchDetailTime") %> )</li>
                                    </ul>
                                </div>
                            </div>
                            <div class="team-2 w-50">
                                <div class="team-details w-100 text-center">
                                    <img src="Assets/images/<%# Eval("OpposingTeamLogo") %>" class="img-fluid">
                                    <h3><%# Eval("OpposingTeamName") %></h3>
                                    <ul class="list-unstyled">
                                        <li><%# Eval("PlayerName") %> ( <%# Eval("MatchDetailTime") %> )</li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>

                </ItemTemplate>
            </asp:Repeater>
        </div>
     


    <div class="site-section">
        <div class="container">
            <div class="row">
                <div class="col-6 title-section">
                    <h2 class="heading">Videos</h2>
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
                <div class="item">
                    <div class="video-media">
                        <img src="Assets/images/img_1.jpg" alt="Image" class="img-fluid">
                        <a href="https://vimeo.com/139714818" class="d-flex play-button align-items-center">
                            <span class="icon mr-3">
                                <span class="icon-play"></span>
                            </span>
                            <div class="caption">
                                <h3 class="m-0">Dogba set for Juvendu return?</h3>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="item">
                    <div class="video-media">
                        <img src="Assets/images/img_2.jpg" alt="Image" class="img-fluid">
                        <a href="https://vimeo.com/139714818" class="d-flex play-button align-items-center">
                            <span class="icon mr-3">
                                <span class="icon-play"></span>
                            </span>
                            <div class="caption">
                                <h3 class="m-0">Kai Nets Double To Secure Comfortable Away Win</h3>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="item">
                    <div class="video-media">
                        <img src="Assets/images/img_3.jpg" alt="Image" class="img-fluid">
                        <a href="https://vimeo.com/139714818" class="d-flex play-button align-items-center">
                            <span class="icon mr-3">
                                <span class="icon-play"></span>
                            </span>
                            <div class="caption">
                                <h3 class="m-0">Romolu to stay at Real Nadrid?</h3>
                            </div>
                        </a>
                    </div>
                </div>

                <div class="item">
                    <div class="video-media">
                        <img src="Assets/images/img_1.jpg" alt="Image" class="img-fluid">
                        <a href="https://vimeo.com/139714818" class="d-flex play-button align-items-center">
                            <span class="icon mr-3">
                                <span class="icon-play"></span>
                            </span>
                            <div class="caption">
                                <h3 class="m-0">Dogba set for Juvendu return?</h3>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="item">
                    <div class="video-media">
                        <img src="Assets/images/img_2.jpg" alt="Image" class="img-fluid">
                        <a href="https://vimeo.com/139714818" class="d-flex play-button align-items-center">
                            <span class="icon mr-3">
                                <span class="icon-play"></span>
                            </span>
                            <div class="caption">
                                <h3 class="m-0">Kai Nets Double To Secure Comfortable Away Win</h3>
                            </div>
                        </a>
                    </div>
                </div>
                <div class="item">
                    <div class="video-media">
                        <img src="Assets/images/img_3.jpg" alt="Image" class="img-fluid">
                        <a href="https://vimeo.com/139714818" class="d-flex play-button align-items-center">
                            <span class="icon mr-3">
                                <span class="icon-play"></span>
                            </span>
                            <div class="caption">
                                <h3 class="m-0">Romolu to stay at Real Nadrid?</h3>
                            </div>
                        </a>
                    </div>
                </div>

            </div>

        </div>
    </div>

    <div class="container site-section">
        <div class="row">
            <div class="col-6 title-section">
                <h2 class="heading">Our Blog</h2>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-6">
                <div class="custom-media d-flex">
                    <div class="img mr-4">
                        <img src="Assets/images/img_1.jpg" alt="Image" class="img-fluid" />
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
    </div>
</asp:Content>
