﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnHotel.aspx.cs" Inherits="DMUBMSFrontOffice.AnHotel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>DMUBMS</title>
    <style type="text/css">
        .auto-style1 {
            width: 991px;
            height: 167px;
            position: absolute;
            top: 5px;
            left: 8px;
            z-index: 1;
        }
        .auto-style2 {
            width: 991px;
            height: 93px;
            position: absolute;
            top: 773px;
            left: 6px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 18px;
            left: 179px;
            z-index: 1;
            width: 758px;
            height: 42px;
            margin-top: 0px;
        }
        .auto-style13 {
            position: absolute;
            top: 122px;
            left: 422px;
            z-index: 1;
            width: 184px;
            height: 33px;
        }
        .auto-style25 {
            position: absolute;
            top: 70px;
            left: 364px;
            z-index: 1;
            width: 293px;
            height: 42px;
            margin-top: 0px;
        }
        .auto-style27 {
            position: absolute;
            top: 539px;
            left: 30px;
            z-index: 1;
            width: 87px;
            height: 38px;
            right: 927px;
        }
        .auto-style28 {
            position: absolute;
            top: 547px;
            left: 212px;
            z-index: 1;
            width: 87px;
            height: 38px;
        }
        .auto-style23 {
            position: absolute;
            top: 372px;
            left: 15px;
            z-index: 1;
            width: 241px;
            height: 28px;
            bottom: 277px;
        }
        .auto-style32 {
            position: absolute;
            top: 218px;
            left: 15px;
            z-index: 1;
            width: 217px;
            height: 28px;
        }
        .auto-style33 {
            position: absolute;
            top: 270px;
            left: 14px;
            z-index: 1;
            width: 229px;
            height: 28px;
            margin-top: 0px;
        }
        .auto-style34 {
            position: absolute;
            top: 322px;
            left: 15px;
            z-index: 1;
            width: 231px;
            height: 28px;
        }
        .auto-style35 {
            position: absolute;
            top: 419px;
            left: 13px;
            z-index: 1;
            width: 277px;
            height: 28px;
            right: 754px;
        }
        .auto-style36 {
            position: absolute;
            top: 469px;
            left: 16px;
            z-index: 1;
            width: 223px;
            height: 28px;
        }
        .auto-style37 {
            position: absolute;
            top: 440px;
            left: 21px;
            z-index: 1;
            width: 129px;
            height: 31px;
        }
        .auto-style22 {
            position: absolute;
            top: 486px;
            left: 14px;
            z-index: 1;
            width: 456px;
            height: 63px;
        }
        .auto-style24 {
            position: absolute;
            top: 213px;
            left: 180px;
            z-index: 1;
            width: 279px;
            height: 29px;
        }
        .auto-style40 {
            position: absolute;
            top: 261px;
            left: 180px;
            z-index: 1;
            width: 279px;
            height: 29px;
        }
        .auto-style41 {
            position: absolute;
            top: 311px;
            left: 179px;
            z-index: 1;
            width: 279px;
            height: 29px;
        }
        .auto-style42 {
            position: absolute;
            top: 363px;
            left: 181px;
            z-index: 1;
            width: 279px;
            height: 29px;
        }
        .auto-style44 {
            position: absolute;
            top: 427px;
            left: 172px;
            z-index: 1;
            width: 279px;
            height: 29px;
        }
        .auto-style45 {
            position: absolute;
            top: 421px;
            left: 190px;
            z-index: 1;
            width: 286px;
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblRegNo" runat="server" CssClass="auto-style32" Font-Bold="True" Font-Size="X-Large" ForeColor="Black" Text="RegNo"></asp:Label>
            <asp:Label ID="lblHotelName" runat="server" CssClass="auto-style23" Font-Bold="True" Font-Size="X-Large" ForeColor="Black" Text="Price"></asp:Label>
            <asp:Label ID="lblModel" runat="server" CssClass="auto-style34" Font-Bold="True" Font-Size="X-Large" ForeColor="Black" Text="Model"></asp:Label>
            <asp:Label ID="lblBrand" runat="server" CssClass="auto-style33" Font-Bold="True" Font-Size="X-Large" ForeColor="Black" Text="Brand"></asp:Label>
        </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="Red" CssClass="auto-style1">
            <asp:Label ID="lblHotelManagement" runat="server" 
    CssClass="auto-style25" Text="Car Management" Font-Bold="True" 
                Font-Italic="False" Font-Names="Berlin Sans FB Demi" Font-Overline="False" 
                Font-Size="XX-Large" Font-Strikeout="False" ForeColor="White"></asp:Label>
            <asp:Label ID="lblManageHotels" runat="server" CssClass="auto-style13" Font-Bold="True" Font-Names="Berlin Sans FB Demi" Font-Size="X-Large" ForeColor="White" Text="Manage Cars"></asp:Label>
            <asp:Label ID="Label10" runat="server" CssClass="auto-style12" Font-Bold="True" Font-Italic="False" Font-Names="Berlin Sans FB Demi" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" ForeColor="White" Text="DMU BOOKING MANAGEMENT SYSTEM"></asp:Label>
            <asp:Label ID="lblError" runat="server" CssClass="auto-style22"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server" CssClass="auto-style42"></asp:TextBox>
            <asp:TextBox ID="txtRegNo" runat="server" CssClass="auto-style24"></asp:TextBox>
            <asp:TextBox ID="txtModel" runat="server" CssClass="auto-style41"></asp:TextBox>
            <asp:TextBox ID="txtBrand" runat="server" CssClass="auto-style40"></asp:TextBox>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="Red" CssClass="auto-style2">
        </asp:Panel>
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style28" Font-Size="Large" ForeColor="#666666" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnOk" runat="server" CssClass="auto-style27" Font-Size="Large" ForeColor="#666666" Text="OK" OnClick="btnOk_Click" />
        <p>
        <asp:CheckBox ID="chkActive" runat="server" CssClass="auto-style37" Font-Bold="True" Font-Size="X-Large" ForeColor="Black" Text="Available" />
        </p>
    </form>
</body>
</html>