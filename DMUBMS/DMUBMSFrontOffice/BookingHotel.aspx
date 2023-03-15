<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookingHotel.aspx.cs" Inherits="DMUBMSFrontOffice.BookingHotel" %>

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
    <!-- for-mobile-apps -->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="keywords" content="Classy Hotel Booking Widget Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template,
Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
    <script type="application/x-javascript">
        addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false);
               function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!-- //for-mobile-apps -->
    <!-- js -->
    <script src="js/jquery-2.1.3.min.js" type="text/javascript"></script>
    <!-- //js -->
    <link href="css/style1.css" rel="stylesheet" type="text/css" media="all" />
    <link href='//fonts.googleapis.com/css?family=Poppins:400,300,500,600,700' rel='stylesheet' type='text/css'>
    <style type="text/css">
        .auto-style1 {
            float: none;
            width: 52%;
            margin-bottom: 14px;
        }
        .auto-style2 {
            float: none;
            width: 52%;
            margin-left: 0%;
        }
                .auto-style7 {
            float: none;
            margin-bottom: 14px;
        }
                </style>
</head>
<body>
    <div id="head">
        <div class="wrap">
            <form id="form1" runat="server">
            <div class="logo"><a href="index.html"><img src="images/logo.png" alt="" /></a></div>
            <div class="nav">
                <ul>
                    <li><a href="index.html">Home</a></li>
                    <li><a href="indexHotel.aspx">Hotels</a></li>
                    <li><a href="XXX.html">Flights</a></li>
                    <li><a href="XXX.html">Car Rentals</a></li>
                    <li><a href="contact.html">Contact</a></li>
                </ul>
            </div>
            <div class="clear"></div>
        </div>
    </div>

    <div class="main">
        <h1 class="w3layouts_head">Booking</h1>
                        <div class="w3layouts_main_grid">
                            <asp:TextBox ID="txtHotelName" runat="server" CssClass="auto-style1" OnTextChanged="txtHotelName_TextChanged" Width="520px" Height="18px"></asp:TextBox>
                </div>
                        <div class="w3layouts_main_grid">

                            <asp:TextBox ID="txtStarRating" runat="server" CssClass="auto-style1" Height="16px" Width="214px" OnTextChanged="txtStarRating_TextChanged"></asp:TextBox>
                            <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="auto-style1" Height="16px" Width="214px" OnTextChanged="txtPhoneNumber_TextChanged"></asp:TextBox>

                </div>
                        <div class="w3layouts_main_grid">
                            <asp:TextBox ID="txtHotelAddress" runat="server" CssClass="auto-style7" Height="16px" Width="530px" OnTextChanged="txtHotelAddress_TextChanged"></asp:TextBox>
                </div>
        <div class="w3layouts_main_grid">
                <div class="w3_agileits_main_grid w3l_main_grid">
                    <div class="agileits_grid">
                        <h5>Name * </h5>
                        <div class="auto-style1">
                            <input type="text" name="First name" placeholder="First Name" required="">
                        </div>
                        <div class="auto-style2">
                            <input type="text" name="Last name" placeholder="Last Name" required="">
                        </div>
                        <div class="clear"></div>
                    </div>
                </div>
                <div class="w3_agileits_main_grid w3l_main_grid">
                    <div class="agileits_grid">
                        <h5>E-mail </h5>
                        <input type="email" name="Email" placeholder="ex : myname@gmail.com" required="">
                    </div>
                </div>
                <div class="agileits_main_grid w3_agileits_main_grid">
                    <div class="wthree_grid">
                        <h5>Room Type</h5>
                        <select id="category" name="category" required="">
                            <option value="none">None</option>
                            <option value="category1">Single Room</option>
                            <option value="category2">Double Room</option>
                            <option value="category3">Suit Room</option>

                        </select>
                    </div>
                </div>
                <div class="agileits_w3layouts_main_grid w3ls_main_grid">
                    <div class="agileinfo_grid">
                        <h5>Check In & Time *</h5>

                        <div class="agileits_w3layouts_main_gridl">
                            <input class="date" id="datepicker" name="Text" type="text" value="mm/dd/yyyy" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '08/13/2016';}" required="">
                        </div>
                        <div class="agileits_w3layouts_main_gridr">
                            <input type="time" name="Time" placeholder=" " required="">
                        </div>
                        <div class="clear"> </div>
                    </div>
                </div>
                <div class="agileits_w3layouts_main_grid w3ls_main_grid">
                    <div class="agileinfo_grid">
                        <h5>Check Out & Time *</h5>

                        <div class="agileits_w3layouts_main_gridl">
                            <input class="date" id="datepicker1" name="Text" type="text" value="mm/dd/yyyy" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '08/13/2016';}" required="">
                        </div>
                        <div class="agileits_w3layouts_main_gridr">
                            <input type="time" name="Time" placeholder=" " required="">
                        </div>
                        <div class="clear"> </div>
                    </div>
                </div>
                        <h5>Number of Guests *</h5>
                        <select id="category1" name="category1" required="">
                            <option value="category1">01</option>
                            <option value="category2">02</option>
                            <option value="category3">03</option>
                            <option value="category4">04</option>
                            <option value="category2">05</option>
                            <option value="category3">06</option>
                        </select>
                                        <div class="w3_main_grid_right">
        <asp:Button ID="btnPAYMENT" runat="server" CssClass="auto-style1" Text="PAYMENT" OnClick="btnPAYMENT_Click" type="submit" value="Payment" />
            </div>
    </form>
                </div>



                <div class="w3_main_grid">

                </div>
        </div>
        <!-- Calendar -->
        <link rel="stylesheet" href="css/jquery-ui.css" />
        <script src="js/jquery-ui.js"></script>
        <script>
            $(function () {
                $("#datepicker,#datepicker1").datepicker();
            });
        </script>
        <!-- //Calendar -->
    <div class="footer">
        <div class="wrap">
            <div id="fbr">
                <p>&copy; 2023 DMU Booking Management System . All Rights Reserved | Design by <a href="https://w3layouts.com/">W3layouts</a></p>
                <div class="ft-nav">
                    <ul>
                    <li><a href="index.html">Home</a></li>
                    <li><a href="indexHotel.aspx">Hotels</a></li>
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
