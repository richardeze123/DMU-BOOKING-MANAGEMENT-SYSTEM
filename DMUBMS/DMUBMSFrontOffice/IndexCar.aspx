<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexCar.aspx.cs" Inherits="DMUBMSFrontOffice.IndexCar" %>

<form id="form1" runat="server">

<<!DOCTYPE html>

<html</html> xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DMUBMS</title>
    <link rel="shortcut icon" href="DMUBMS50X50.jpg" type="image/x-icon">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="css/style.css" type="text/css" media="all" />
    <style type="text/css">
        .auto-style1 {
            width: 1000px;
            height: 780px;
        }
        .auto-style2 {
            width: 291px;
            height: 253px;
        }
        .auto-style3 {
            width: 317px;
            height: 253px;
        }
        .auto-style4 {
            width: 311px;
            height: 236px;
        }
        .auto-style5 {
            width: 398px;
            height: 213px;
        }
        .auto-style7 {
            width: 403px;
            height: 289px;
        }
        .auto-style8 {
            width: 338px;
            height: 297px;
        }
        .auto-style9 {
            width: 338px;
            height: 189px;
        }
        .auto-style10 {
            width: 416px;
            height: 287px;
        }
        .auto-style11 {
            width: 363px;
            height: 354px;
        }
        .auto-style12 {
            width: 442px;
            height: 425px;
        }
        .auto-style13 {
            width: 417px;
            height: 309px;
        }
        .auto-style14 {
            width: 404px;
            height: 280px;
        }
        .btn {
            height: 18px;
        }
    </style>
</head>
<body>
<div id="head">
        <div class="wrap">
            <div class="logo"><a href="index.html"><img src="images/logo.png" alt="" /></a></div>
            <div class="nav">
                <ul>
                    <li><a href="index.html">Home</a></li>
                    <li class="active"><a href="indexCar.aspx">Car Rentals</a></li>
                    <li><a href="XXX.html">Flights</a></li>
                    <li><a href="indexHotel.aspx">Hotel</a></li>
                    <li><a href="contact.html">Contact</a></li>
                </ul>
            </div>
            <div class="clear"></div>
        </div>
    </div>
    <div id="header">
        <div class="wrap">
            <div class="sub-header">
                &nbsp;
                <div class="desp">
                    <h1>Cars</h1>
            <h2 class="h2 section-title"><img src="images/Range%20Rover.jpg" /alt="" class="mac"></h2>

</div>
                <div class="clear"></div>
                </div>
                <div class="clear"></div>
            </div>
        </div>
    </div>
    <div id="main">
        <div class="wrap">
            <div class="content">
                <div id="article">
                    <h2>How to Book</h2>
                    <div id="prev">
                        <img class="auto-style1" src="images/CarBooking.jpg" /></div>
                    <p>
                        1. view the car that you want to rent.
                    </p>
                                        <p>
                                            

                    </p>
                    <p>
                        2. After selecting the car from the list, click the Book Now option.
                    </p>
                                                            <p>
                                                                

                    </p>
                    <p>
                        3. Browse the Car details, fill out your personal information and booking information, and then click the Payment option.
                    </p>
                                                            <p>
                                                               

                    </p>
                    <p>
                        4. Provide your payment information in detail.
                    </p>
                                                            <p                                         
                    </p>
                    <p>
                        5. Check the information regarding your payment and booking, then click Finish.
                    </p>

                                                                                <p>
   
                    </p>

                    


                    <div class="sidebar">
                <div class="sub-sidebar">
                    <h2>Our Cars </h2>
                    <p>Welcome to our car rental website! We offer a wide range of vehicles to suit your travel needs. Our cars are reliable, well-maintained, and equipped with the latest features for a comfortable and safe ride. From compact cars for city driving to spacious SUVs for family vacations, we have something for everyone. Our fleet includes popular makes and models from top manufacturers, so you can choose the car that fits your preferences and budget. With our easy booking process and competitive rates, renting a car has never been easier. Explore new places and enjoy the freedom of the road with our quality rental cars. </p>
                    
                    <div class="clear"></div>
                </div>
                <div id="article">
            </div>
        </div>
    </div>

    <div id="main">
        <div class="wrap">
            <div class="content">
                <div id="article">
                    <section class="section featured-car" id="featured-car">
        <div class="container">

          <div class="title-wrapper">

            <a href="#" class="featured-car-link">
              <span>View cars</span>

              <ion-icon name="arrow-forward-outline"></ion-icon>
            </a>
          </div>

          <ul class="featured-car-list">

            <li>
              <div class="featured-car-card">

                <figure class="card-banner">
                  &nbsp;<img class="auto-style2" src="images/Toyota%20RAV4.jpg" /></figure>

                <div class="card-content">

                  <div class="card-title-wrapper">
                    <h3 class="h3 card-title">
                      <a href="#">Toyota RAV4</a>
                    </h3>

                    <data class="year" value="2021">2021</data>
                  </div>

                  <ul class="card-list">

                    <li class="card-list-item">
                      <ion-icon name="people-outline"></ion-icon>

                      <span class="card-item-text">4 People</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="flash-outline"></ion-icon>

                      <span class="card-item-text">Hybrid</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="speedometer-outline"></ion-icon>

                      <span class="card-item-text">6.1km / 1-litre</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="hardware-chip-outline"></ion-icon>

                      <span class="card-item-text">Automatic</span>
                    </li>

                  </ul>

                  <div class="card-price-wrapper">

                    <p class="card-price">
                      <strong>£440</strong>
                        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Book now" />
                    </p>

                    

                  </div>

                </div>

              </div>
            </li>

            <li>
              <div class="featured-car-card">

                <figure class="card-banner">
                  &nbsp;<img class="auto-style3" src="images/bmw-3-series.jpg" /></figure>

                <div class="card-content">

                  <div class="card-title-wrapper">
                    <h3 class="h3 card-title">
                      <a href="#">BMW 3 Series</a>
                    </h3>

                    <data class="year" value="2019">2019</data>
                  </div>

                  <ul class="card-list">

                    <li class="card-list-item">
                      <ion-icon name="people-outline"></ion-icon>

                      <span class="card-item-text">4 People</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="flash-outline"></ion-icon>

                      <span class="card-item-text">Gasoline</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="speedometer-outline"></ion-icon>

                      <span class="card-item-text">8.2km / 1-litre</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="hardware-chip-outline"></ion-icon>

                      <span class="card-item-text">Automatic</span>
                    </li>

                  </ul>

                  <div class="card-price-wrapper">

                    <p class="card-price">
                        £<strong>350</strong>
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Book now" />
                    </p>

                  </div>

                </div>

              </div>
            </li>

            <li>
              <div class="featured-car-card">

                <figure class="card-banner">
                  &nbsp;<img class="auto-style4" src="images/vw%20T-cross.jpg" /></figure>

                <div class="card-content">

                  <div class="card-title-wrapper">
                    <h3 class="h3 card-title">
                      <a href="#">Volkswagen T-Cross</a>
                    </h3>

                    <data class="year" value="2020">2020</data>
                  </div>

                  <ul class="card-list">

                    <li class="card-list-item">
                      <ion-icon name="people-outline"></ion-icon>

                      <span class="card-item-text">4 People</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="flash-outline"></ion-icon>

                      <span class="card-item-text">Gasoline</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="speedometer-outline"></ion-icon>

                      <span class="card-item-text">5.3km / 1-litre</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="hardware-chip-outline"></ion-icon>

                      <span class="card-item-text">Automatic</span>
                    </li>

                  </ul>
                    <div class="card-price-wrapper">

                        <p class="card-price">
                            <strong>£400</strong></p>
                        <p class="card-price">
                      &nbsp;<asp:Button ID="Button3" runat="server" Height="41px" OnClick="Button3_Click" Text="Book Now" Width="386px" />
                    </p>

                  </div>

                </div>

              </div>
            </li>

            <li>
              <div class="featured-car-card">

                <figure class="card-banner">
                  &nbsp;<img class="auto-style5" src="images/Cadillac%20Escalade.jpg" /></figure>

                <div class="card-content">

                  <div class="card-title-wrapper">
                    <h3 class="h3 card-title">
                      <a href="#">Cadillac Escalade</a>
                    </h3>

                    <data class="year" value="2020">2020</data>
                  </div>

                  <ul class="card-list">

                    <li class="card-list-item">
                      <ion-icon name="people-outline"></ion-icon>

                      <span class="card-item-text">4 People</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="flash-outline"></ion-icon>

                      <span class="card-item-text">Gasoline</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="speedometer-outline"></ion-icon>

                      <span class="card-item-text">7.7km / 1-litre</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="hardware-chip-outline"></ion-icon>

                      <span class="card-item-text">Automatic</span>
                    </li>

                  </ul>

                  <div class="card-price-wrapper">

                    <p class="card-price">
                        £<strong>620<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Book Now" />
                        </strong>
                    </p>

                  </div>

                </div>

              </div>
            </li>

            <li>
              <div class="featured-car-card">

                <figure class="card-banner">
                  &nbsp;<img class="auto-style7" src="images/bmw-4-series-m-sport.jpg" /></figure>

                <div class="card-content">

                  <div class="card-title-wrapper">
                    <h3 class="h3 card-title">
                      <a href="#">BMW 4 Series GTI</a>
                    </h3>

                    <data class="year" value="2021">2021</data>
                  </div>

                  <ul class="card-list">

                    <li class="card-list-item">
                      <ion-icon name="people-outline"></ion-icon>

                      <span class="card-item-text">4 People</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="flash-outline"></ion-icon>

                      <span class="card-item-text">Gasoline</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="speedometer-outline"></ion-icon>

                      <span class="card-item-text">7.6km / 1-litre</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="hardware-chip-outline"></ion-icon>

                      <span class="card-item-text">Automatic</span>
                    </li>

                  </ul>

                  <div class="card-price-wrapper">

                    <p class="card-price">
                        £<strong>530</strong>/month
                        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Book Now" />
                    </p>

                  </div>

                </div>

              </div>
            </li>

            <li>
              <div class="featured-car-card">

                <figure class="card-banner">
                  &nbsp;<img class="auto-style8" src="images/bmw%204%20series%20frop%20top.jpg" /></figure>

                <div class="card-content">

                  <div class="card-title-wrapper">
                    <h3 class="h3 card-title">
                      <a href="#">BMW 4 Series drop top</a>
                    </h3>

                    <data class="year" value="2019">2019</data>
                  </div>

                  <ul class="card-list">

                    <li class="card-list-item">
                      <ion-icon name="people-outline"></ion-icon>

                      <span class="card-item-text">4 People</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="flash-outline"></ion-icon>

                      <span class="card-item-text">Gasoline</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="speedometer-outline"></ion-icon>

                      <span class="card-item-text">7.2km / 1-litre</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="hardware-chip-outline"></ion-icon>

                      <span class="card-item-text">Automatic</span>
                    </li>

                  </ul>

                  <div class="card-price-wrapper">

                    <p class="card-price">
                        £<strong>490</strong>/month
                        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Book Now" />
                    </p>

                  </div>

                </div>

              </div>
            </li>

          </ul>

        </div>
      </section>
                    <a href="#" class="featured-car-link">
              <span></span>

              <ion-icon name="arrow-forward-outline"></ion-icon>
            </a>
          </div>

          <ul class="featured-car-list">

            <li>
              <div class="featured-car-card">

                <figure class="card-banner">
                  &nbsp;<img class="auto-style9" src="images/Hel%20lcat.jpg" /></figure>

                <div class="card-content">

                  <div class="card-title-wrapper">
                    <h3 class="h3 card-title">
                      <a href="#">Doge Hellcat </h3>

                    <data class="year" value="2021">2021</data>
                  </div>

                  <ul class="card-list">

                    <li class="card-list-item">
                      <ion-icon name="people-outline"></ion-icon>

                      <span class="card-item-text">4 People</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="flash-outline"></ion-icon>

                      <span class="card-item-text">Hybrid</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="speedometer-outline"></ion-icon>

                      <span class="card-item-text">6.1km / 1-litre</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="hardware-chip-outline"></ion-icon>

                      <span class="card-item-text">Automatic</span>
                    </li>

                  </ul>

                  <div class="card-price-wrapper">

                    <p class="card-price">
                      <strong>£440</strong>
                       
                        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Book Now" />
                    </p>

                  </div>

                </div>

              </div>
            </li>

            <li>
              <div class="featured-car-card">

                <figure class="card-banner">
                  &nbsp;<img class="auto-style10" src="images/VW%20Golf.jpg" /></figure>

                <div class="card-content">

                  <div class="card-title-wrapper">
                    <h3 class="h3 card-title">
                      <a href="#">VW Golf</h3>

                    <data class="year" value="2019">2019</data>
                  </div>

                  <ul class="card-list">

                    <li class="card-list-item">
                      <ion-icon name="people-outline"></ion-icon>

                      <span class="card-item-text">4 People</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="flash-outline"></ion-icon>

                      <span class="card-item-text">Gasoline</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="speedometer-outline"></ion-icon>

                      <span class="card-item-text">8.2km / 1-litre</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="hardware-chip-outline"></ion-icon>

                      <span class="card-item-text">Automatic</span>
                    </li
                    </li>

                  </ul>

                  <div class="card-price-wrapper">

                    <p class="card-price">
                      <strong>$350</strong>/month
                        <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Book Now" />
                    </p>

                  </div>

                </div>

              </div>
            </li>

            <li>
              <div class="featured-car-card">

                <figure class="card-banner">
                  &nbsp;<img class="auto-style11" src="images/VW_Polo.jpg" /></figure>

                <div class="card-content">

                  <div class="card-title-wrapper">
                    <h3 class="h3 card-title">
                      <a href="#">VW Polo</h3>

                    <data class="year" value="2020">2020</data>
                  </div>

                  <ul class="card-list">

                    <li class="card-list-item">
                      <ion-icon name="people-outline"></ion-icon>

                      <span class="card-item-text">4 People</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="flash-outline"></ion-icon>

                      <span class="card-item-text">Gasoline</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="speedometer-outline"></ion-icon>

                      <span class="card-item-text">5.3km / 1-litre</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="hardware-chip-outline"></ion-icon>

                      <span class="card-item-text">Automatic</span>
                    </li
                    </li>

                  </ul>

                  <div class="card-price-wrapper">

                    <p class="card-price">
                        £<strong>400</strong>/month
                        <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="Book Now" />
                    </p>

                  </div>

                </div>

              </div>
            </li>

            <li>
              <div class="featured-car-card">

                <figure class="card-banner">
                  &nbsp;<img class="auto-style12" src="images/Vauxhall-Astra-2020.jpg" /></figure>

                <div class="card-content">

                  <div class="card-title-wrapper">
                    <h3 class="h3 card-title">
                      <a href="#">Vauxhall Astra</h3>

                    <data class="year" value="2020">2020</data>
                  </div>

                  <ul class="card-list">

                    <li class="card-list-item">
                      <ion-icon name="people-outline"></ion-icon>

                      <span class="card-item-text">4 People</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="flash-outline"></ion-icon>

                      <span class="card-item-text">Gasoline</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="speedometer-outline"></ion-icon>

                      <span class="card-item-text">7.7km / 1-litre</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="hardware-chip-outline"></ion-icon>

                      <span class="card-item-text">Automatic</span>
                    </li
                    </li>

                  </ul>

                  <div class="card-price-wrapper">

                    <p class="card-price">
                        £<strong>620</strong>/month
                        <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="Book Now" />
                    </p>

                  </div>

                </div>

              </div>
            </li>

            <li>
              <div class="featured-car-card">

                <figure class="card-banner">
                  &nbsp;<img class="auto-style13" src="images/Track%20hawk.jpg" /></figure>

                <div class="card-content">

                  <div class="card-title-wrapper">
                    <h3 class="h3 card-title">
                      <a href="#">Jeep Track Hawk</h3>

                    <data class="year" value="2021">2021</data>
                  </div>

                  <ul class="card-list">

                    <li class="card-list-item">
                      <ion-icon name="people-outline"></ion-icon>

                      <span class="card-item-text">4 People</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="flash-outline"></ion-icon>

                      <span class="card-item-text">Gasoline</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="speedometer-outline"></ion-icon>

                      <span class="card-item-text">7.6km / 1-litre</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="hardware-chip-outline"></ion-icon>

                      <span class="card-item-text">Automatic</span>
                    </li
                    </li>

                  </ul>

                  <div class="card-price-wrapper">

                    <p class="card-price">
                        <strong>£530</strong>/month
                        <asp:Button ID="Button2" runat="server" Height="35px" OnClick="Button2_Click" Text="Book Now" Width="255px" />
                    </p>

                  </div>

                </div>

              </div>
            </li>

            <li>
              <div class="featured-car-card">

                <figure class="card-banner">
                  &nbsp;<img class="auto-style14" src="images/Audi%20q2.jpg" /></figure>

                <div class="card-content">

                  <div class="card-title-wrapper">
                    <h3 class="h3 card-title">
                      <a href="#">Audi q2</h3>

                    <data class="year" value="2019">2019</data>
                  </div>

                  <ul class="card-list">

                    <li class="card-list-item">
                      <ion-icon name="people-outline"></ion-icon>

                      <span class="card-item-text">4 People</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="flash-outline"></ion-icon>

                      <span class="card-item-text">Gasoline</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="speedometer-outline"></ion-icon>

                      <span class="card-item-text">7.2km / 1-litre</span>
                    </li>

                    <li class="card-list-item">
                      <ion-icon name="hardware-chip-outline"></ion-icon>

                      <span class="card-item-text">Automatic</span>
                    </li>

                  </ul>

                  <div class="card-price-wrapper">

                    <p class="card-price">
                      <strong>$490</strong> / month
                    </p>

                      <asp:Button ID="Button1" runat="server" Height="30px" Text="Book Now" Width="250px" OnClick="Button1_Click" />

                  </div>

                </div>

              </div>

            </li>

          </ul>

    

        </div>
      <div class="clear"></div>
    </div>
    <div class="footer">
        <div class="wrap">
            <div id="fbr">
                <p>&copy; 2023 DMU Booking Management System . All Rights Reserved | Design by <a href="https://w3layouts.com/">W3layouts</a></p>
                <div class="ft-nav">
                    <ul>
                        <li><a href="index.html">Home</a></li>
                        <li class="active"><a href="IndexCar.aspx">Cars</a></li>
                        <li><a href="XXX.html">Flights</a></li>
                        <li><a href="indexHotel.aspx">Hotels</a></li>
                        <li><a href="contact.html" media="screen" aria-orientation="horizontal">Contact</a></li>
                    </ul>
                </div>
                <div class="clear"></div>
    

</form>

    

