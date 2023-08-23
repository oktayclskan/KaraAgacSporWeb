<%@ Page Title="" Language="C#" MasterPageFile="~/KaraagacSporWebb.Master" AutoEventWireup="true" CodeBehind="blog.aspx.cs" Inherits="KaraagacSporWebb.blog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="hero overlay" style="background-image: url('Assets/images/bg_3.jpg');">
        <div class="container">
            <div class="row align-items-center">
                <div class="col-lg-5 mx-auto text-center">
                    <h1 class="text-white">Haberler</h1>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Soluta, molestias repudiandae pariatur.</p>
                </div>
            </div>
        </div>
    </div>

    <div class="container site-section">
        <div class="row">

            <div class="col-6 title-section">
                <h2 class="heading">Gündem </h2>
            </div>
        </div>
        <div class="row">
            <asp:Repeater ID="rp_news" runat="server">
                <ItemTemplate>
                    <div class="col-lg-4 mb-4">
                        <div class="custom-media d-block">
                            <div class="img mb-4">
                                <a href="single.aspx">
                                    <img src="AdminPanel/Assets/Img/<%# Eval("NewsCardImg") %>" alt="Image" class="img-fluid" /></a>
                            </div>
                            <div class="text">
                                <span class="meta"><%# Eval("NewsDateStr") %></span>
                                <h3 class="mb-4"><a href="#"><%#Eval("NewsTitle") %></a></h3>
                                <p style="height: 200px"><%#Eval("NewsDescription") %></p>
                                <p><a href="#">Devamı</a></p>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>

        <%-- <div class="col-lg-4 mb-4">
          <div class="custom-media d-block">
            <div class="img mb-4">
              <a href="single.aspx"><img src="Assets/images/img_3.jpg" alt="Image" class="img-fluid"/></a>
            </div>
            <div class="text">
              <span class="meta">May 20, 2020</span>
              <h3 class="mb-4"><a href="#">Romolu to stay at Real Nadrid?</a></h3>
              <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Possimus deserunt saepe tempora dolorem.</p>
              <p><a href="#">Read more</a></p>
            </div>
          </div>
        </div>--%>
    </div>

</asp:Content>
