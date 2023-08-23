<%@ Page Title="" Language="C#" MasterPageFile="~/KaraagacSporWebb.Master" AutoEventWireup="true" CodeBehind="MatchseRead.aspx.cs" Inherits="KaraagacSporWebb.MatchseRead" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="hero overlay" style="background-image: url('Assets/images/bg_3.jpg');">
        <div class="container">
            <div class="row align-items-center">
                <div class="col-lg-5 mx-auto text-center">
                    <h1 class="text-white">Maç Detay</h1>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Soluta, molestias repudiandae pariatur.</p>
                </div>
            </div>
        </div>
    </div>
    <div class="container">





        <asp:Repeater ID="rp_matchDetail" runat="server">
            <ItemTemplate>
                <div class="col-lg-12">
                    <div class="d-flex team-vs">
                        <span class="score">4-1</span>
                        <div class="team-1 w-50">
                            <div class="team-details w-100 text-center">
                                <img src="Assets/images/logo_1.png" alt="Image" class="img-fluid" />
                                <h3>LA LEGA <span>(win)</span></h3>
                                <ul class="list-unstyled">
                                    <li>Anja Landry (7)</li>
                                    <li>Eadie Salinas (12)</li>
                                    <li>Ashton Allen (10)</li>
                                    <li>Baxter Metcalfe (5)</li>
                                </ul>
                            </div>
                        </div>
                        <div class="team-2 w-50">
                            <div class="team-details w-100 text-center">
                                <img src="Assets/images/logo_2.png" alt="Image" class="img-fluid" />
                                <h3>JUVENDU <span>(loss)</span></h3>
                                <ul class="list-unstyled">
                                    <li>Macauly Green (3)</li>
                                    <li>Arham Stark (8)</li>
                                    <li>Stephan Murillo (9)</li>
                                    <li>Ned Ritter (5)</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>














        <div class="col-lg-12 mt-5">
            <div class="d-flex team-vs mt-5">
                <span class="score">4-1</span>
                <div class="team-1 w-50">
                    <div class="team-details w-100 text-center">
                        <img src="Assets/images/logo_1.png" alt="Image" class="img-fluid" />
                        <h3>LA LEGA <span>(win)</span></h3>
                        <ul class="list-unstyled">
                            <li>Anja Landry (7)</li>
                            <li>Eadie Salinas (12)</li>
                            <li>Ashton Allen (10)</li>
                            <li>Baxter Metcalfe (5)</li>
                        </ul>
                    </div>
                </div>
                <div class="team-2 w-50">
                    <div class="team-details w-100 text-center">
                        <img src="Assets/images/logo_2.png" alt="Image" class="img-fluid" />
                        <h3>JUVENDU <span>(loss)</span></h3>
                        <ul class="list-unstyled">
                            <li>Macauly Green (3)</li>
                            <li>Arham Stark (8)</li>
                            <li>Stephan Murillo (9)</li>
                            <li>Ned Ritter (5)</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
