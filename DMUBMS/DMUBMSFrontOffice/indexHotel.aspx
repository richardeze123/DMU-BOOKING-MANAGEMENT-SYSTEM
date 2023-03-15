<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexHotel.aspx.cs" Inherits="DMUBMSFrontOffice.indexHotel" %>

<!--
Author: W3layouts
Author URL: http://w3layouts.com
License: Creative Commons Attribution 3.0 Unported
License URL: http://creativecommons.org/licenses/by/3.0/
-->

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DMUBMS</title>
    <link rel="shortcut icon" href="DMUBMS50X50.jpg" type="image/x-icon">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="css/style.css" type="text/css" media="all" />
    <style type="text/css">
        .auto-style1 {
            float: none;
            width: 52%;
            margin-bottom: 14px;
        }
        .auto-style2 {
            float: none;
            width: 52%;
            margin-bottom: 14px;
            margin-left: 0px;
        }
        .auto-style3 {
            position: absolute;
            top: 736px;
            left: 1082px;
            z-index: 1;
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
                    <li class="active"><a href="indexHotel.aspx">Hotels</a></li>
                    <li><a href="XXX.html">Flights</a></li>
                    <li><a href="XXX.html">Car Rentals</a></li>
                    <li><a href="contact.html">Contact</a></li>
                </ul>
            </div>
            <div class="clear"></div>
        </div>
    </div>
    <div id="header">
        <div class="wrap">
            <div class="sub-header">
                <img src="images/indexHotel.gif" alt="" width="310" class="mac" />
                <div class="desp">
                    <h1>Hotels</h1>
                    <p>Welcome to the Hotels section of DMU Booking Management System! We offer a vast selection of hotels worldwide, ranging from budget-friendly options to luxury resorts. Whether you're traveling for business or pleasure, our platform provides you with the flexibility to book your hotel accommodations with ease. Plus, our team of travel experts is always available to help you with any questions or concerns you may have. Book your next hotel stay with DMU Booking Management System and experience the convenience and reliability of our platform.</p>
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
                    <div id="prev"><img src="images/indexHotel2.gif" alt="" /></div>
                    <p>
                        1.	Navigate to the Hotels section.
                    </p>
                    <p>
                        2.	Browse through the list of hotels and click on the one you want to book.
                    </p>
                    <p>
                        3.	On the hotel page, review the hotel's description, facilities, and room types available.
                    </p>
                    <p>
                        4.	If you're satisfied with your selection, click on the "Book Now" button.
                    </p>
                    <p>
                        5.	Enter your personal information and complete your booking details.
                    </p>
                    <p>
                        6.	Enter your payment information.
                    </p>
                    <p>
                        7.	Review your booking details and click on the "Finish" button.
                    </p>
                    <p>
                        8.	After the booking is confirmed, you will receive an email confirmation with the details of your reservation.
                    </p>
                    <div class="clear"></div>
                </div>
                <div id="article">
                    <h2>Reviews</h2>
                    <p>
                        ⭐⭐⭐⭐⭐
                    </p>
                    <p>
                        Jack Hughes - Would be happy to recommend this site to other travellers.
                    </p>
                    <p>
                        ⭐⭐⭐⭐⭐
                    </p>
                    <p>
                        Jose Cook - The site is absolutely great for booking as well as cancellations.
                    </p>
                    <p>
                        ⭐⭐⭐⭐⭐
                    </p>
                    <p>
                        Larry Smith - I would recommend this site to anyone thinking of making a booking.
                    </p>
                    <p>
                        ⭐⭐⭐⭐⭐
                    </p>
                    <p>
                        Olivia Smith - Excellent site: Information, accessibility and presentation are excellent.
                    </p>
                    <p>
                        ⭐⭐⭐⭐⭐
                    </p>
                    <p>
                        Arthur Baker - Easy page, all bookings were perfect.
                    </p>
                    <div class="clear"></div>
                </div>
            </div>
            <div class="sidebar">
                <div class="sub-sidebar">
                    <h2>Rooms</h2>
                    <ul class="sub-nav">
                        <li><a href="#">Single Room : £50</a></li>
                        <li><a href="#">Double Room: £75</a></li>
                        <li><a href="#">Suit Room: £100
                            </a></li>
                    </ul>
                </div>
                <div class="sub-sidebar">
                    <asp:Label ID="lblError" runat="server" CssClass="auto-style1" Width="250px"></asp:Label>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstHotels" runat="server" CssClass="auto-style2" OnSelectedIndexChanged="lstHotels_SelectedIndexChanged" Height="327px" Width="242px"></asp:ListBox>
        <asp:Button ID="btnBookNow" runat="server" CssClass="auto-style1" Text="Book Now" OnClick="btnBookNow_Click" Width="250px" />
    </form>
                </div>
            </div>
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
                        <li class="active"><a href="indexHotel.aspx">Hotels</a></li>
                        <li><a href="XXX.html">Flights</a></li>
                        <li><a href="XXX.html">Car Rentals</a></li>
                        <li><a href="contact.html">Contact</a></li>
                    </ul>
                </div>
                <div class="clear"></div>
            </div>
        </div>
    </div>
</body>
</html>