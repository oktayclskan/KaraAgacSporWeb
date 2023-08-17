<%@ Page Title="" Language="C#" MasterPageFile="~/KaraagacSporWebb.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="KaraagacSporWebb.contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="hero overlay" style="background-image: url('Assets/images/bg_3.jpg');">
      <div class="container">
        <div class="row align-items-center">
          <div class="col-lg-9 mx-auto text-center">
            <h1 class="text-white">İletişim</h1>
          </div>
        </div>
      </div>
    </div>
    <div class="site-section">
      <div class="container">
        <div class="row">
          <div class="col-lg-7">
              <div class="form-group">
                  <div class="row">
                      <div class="col-lg-6">
                            <input type="text" class="form-control" placeholder="İsim">
                      </div>
                      <div class="col-lg-6">
                          <input type="text" class="form-control" placeholder="Soyisim">
                      </div>
                  </div>
              
              </div>
              <div class="form-group">
                <input type="text" class="form-control" placeholder="E-Posta">
              </div>
           
              <div class="form-group">
                <textarea name="" class="form-control" id="" cols="30" rows="10" placeholder="Mesajınız..."></textarea>
              </div>
              <div class="form-group">
                <input type="submit" class="btn btn-primary py-3 px-5 d-block w-100" value="Gönder">
              </div>
          </div>
          <div class="col-lg-4 ml-auto">
            
            <ul class="list-unstyled">
              <li class="mb-2">
                <strong class="text-white d-block">ADRES</strong>
                273 XXXXXXXw Cd. <br> Eskişehir, No 10011
              </li>
              <li class="mb-2">
                <strong class="text-white d-block">E-POSTA</strong>
                <a href="#">XXXXXXX@GMAİL.coM</a>
              </li>
              <li class="mb-2">
                <strong class="text-white d-block">
                  Phone
                </strong>
                <a href="#">054X XXX XX XX</a>
              </li>
            </ul>
          </div>
        </div>
      </div>
    </div>
</asp:Content>
