<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="DMUBMSFrontOffice.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
        .auto-style3 {
            position: absolute;
            top: 242px;
            left: 373px;
            z-index: 1;
            width: 260px;
            height: 258px;
        }
        .auto-style4 {
            position: absolute;
            top: 250px;
            left: 685px;
            z-index: 1;
            width: 267px;
            height: 246px;
        }
        .auto-style5 {
            position: absolute;
            top: 322px;
            left: 16px;
            z-index: 1;
            height: 160px;
            width: 323px;
        }
        .auto-style6 {
            width: 234px;
            height: 151px;
            position: absolute;
            top: 577px;
            left: 51px;
            z-index: 1;
        }
        .auto-style7 {
            width: 244px;
            height: 149px;
            position: absolute;
            top: 579px;
            left: 370px;
            z-index: 1;
        }
        .auto-style8 {
            width: 249px;
            height: 150px;
            position: absolute;
            top: 580px;
            left: 698px;
            z-index: 1;
        }
        .auto-style9 {
            width: 244px;
            height: 43px;
            position: absolute;
            top: 0px;
            left: 0px;
            z-index: 1;
        }
        .auto-style10 {
            width: 249px;
            height: 45px;
            position: absolute;
            top: 0px;
            left: 0px;
            z-index: 1;
            bottom: 105px;
        }
        .auto-style11 {
            width: 234px;
            height: 44px;
            position: absolute;
            top: 0px;
            left: 0px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 25px;
            left: 210px;
            z-index: 1;
            width: 685px;
            height: 42px;
            margin-top: 0px;
        }
        .auto-style13 {
            position: absolute;
            top: 87px;
            left: 432px;
            z-index: 1;
            width: 154px;
            height: 33px;
        }
        .auto-style14 {
            position: absolute;
            top: 2px;
            left: -234px;
            z-index: 1;
            width: 61px;
            height: 30px;
        }
        .auto-style15 {
            position: absolute;
            top: 4px;
            left: 86px;
            z-index: 1;
        }
        .auto-style16 {
            position: absolute;
            top: 6px;
            left: 87px;
            z-index: 1;
            width: 98px;
            height: 32px;
            right: 64px;
        }
        .auto-style17 {
            position: absolute;
            top: 626px;
            left: 699px;
            z-index: 1;
            width: 248px;
            height: 103px;
        }
        .auto-style18 {
            position: absolute;
            top: 43px;
            left: -319px;
            z-index: 1;
            width: 234px;
            height: 105px;
        }
        .auto-style19 {
            position: absolute;
            top: 44px;
            left: 1px;
            z-index: 1;
            width: 243px;
            height: 104px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="OrangeRed" CssClass="auto-style1">
            <asp:Label ID="lbldmubms" runat="server" 
    CssClass="auto-style12" Text="DMU BOOKING MANAGEMENT SYSTEM" Font-Bold="True" 
                Font-Italic="False" Font-Names="Berlin Sans FB Demi" Font-Overline="False" 
                Font-Size="XX-Large" Font-Strikeout="False" ForeColor="White"></asp:Label>
            <asp:Label ID="lblHomePage" runat="server" CssClass="auto-style13" Font-Bold="True" 
                Font-Names="Berlin Sans FB Demi" Font-Size="X-Large" ForeColor="White" 
                Text="Home Page"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="OrangeRed" CssClass="auto-style2">
        </asp:Panel>
        <asp:Image ID="Image1" runat="server" CssClass="auto-style3" 
            ImageUrl="~/hotel.jpg" />
        <asp:Image ID="Image2" runat="server" CssClass="auto-style4" 
            ImageUrl="~/plane.jpg" />
        <asp:Image ID="Image3" runat="server" CssClass="auto-style5" 
            ImageUrl="~/car.jpg" />
        <asp:Panel ID="Panel3" runat="server" BorderColor="#FF0066" 
            CssClass="auto-style6">
            <asp:Panel ID="Panel9" runat="server" 
    CssClass="auto-style11" BackColor="#CC0066">
            </asp:Panel>
        </asp:Panel>
        <asp:Panel ID="Panel4" runat="server" BorderColor="#33CC33" 
            CssClass="auto-style7">
            <asp:Panel ID="Panel7" runat="server" 
    CssClass="auto-style9" BackColor="#009933">
                <asp:Label ID="Label3" runat="server" CssClass="auto-style14" Font-Bold="True" 
                    Font-Names="Arial Unicode MS" Font-Size="X-Large" ForeColor="White" Text="Cars"></asp:Label>
                <asp:Label ID="Label4" runat="server" CssClass="auto-style15" Font-Bold="True" 
                    Font-Names="Arial Unicode MS" Font-Size="X-Large" ForeColor="White" 
                    Text="Hotels"></asp:Label>
            </asp:Panel>
            <asp:Button ID="btnGo1" runat="server" CssClass="auto-style18" 
                Font-Bold="True" Font-Italic="False" Font-Names="Akzidenz-Grotesk Pro Bold Ext" 
                Font-Size="XX-Large" ForeColor="#666666" OnClick="Button2_Click" Text="GO" />
            <asp:Button ID="btnGo2" runat="server" CssClass="auto-style19" 
                Font-Bold="True" Font-Names="Akzidenz-Grotesk Pro Bold Ext" 
                Font-Size="XX-Large" ForeColor="#666666" OnClick="Button3_Click" Text="GO" />
        </asp:Panel>
        <asp:Panel ID="Panel5" runat="server" BorderColor="Blue" CssClass="auto-style8">
            <asp:Panel ID="Panel8" runat="server" 
    CssClass="auto-style10" BackColor="#000099">
                <asp:Label ID="Label5" runat="server" CssClass="auto-style16" Font-Bold="True" 
                    Font-Names="Arial Unicode MS" Font-Size="X-Large" ForeColor="White" 
                    Text="Flights"></asp:Label>
            </asp:Panel>
        </asp:Panel>
        <asp:Button ID="btnGo3" runat="server" CssClass="auto-style17" 
            Font-Bold="True" Font-Names="Akzidenz-Grotesk Pro Bold Ext" 
            Font-Size="XX-Large" ForeColor="#666666" OnClick="Button1_Click1" Text="GO" />
    </form>
</body>
</html>
