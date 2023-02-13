<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HotelRegister.aspx.cs" Inherits="DMUBMSFrontOffice.HotelRegister" %>

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
            top: 269px;
            left: 235px;
            z-index: 1;
            width: 252px;
            height: 240px;
            margin-top: 0px;
        }
        .auto-style4 {
            width: 204px;
            height: 619px;
            position: absolute;
            top: 164px;
            left: 8px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 534px;
            left: 312px;
            z-index: 1;
            width: 115px;
            height: 30px;
        }
        .auto-style6 {
            position: absolute;
            top: 573px;
            left: 296px;
            z-index: 1;
            width: 148px;
            height: 30px;
        }
        .auto-style7 {
            position: absolute;
            top: 614px;
            left: 300px;
            z-index: 1;
            width: 137px;
            height: 26px;
        }
        .auto-style12 {
            position: absolute;
            top: 17px;
            left: 221px;
            z-index: 1;
            width: 581px;
            height: 42px;
            margin-top: 0px;
        }
        .auto-style13 {
            position: absolute;
            top: 119px;
            left: 448px;
            z-index: 1;
            width: 113px;
            height: 33px;
        }
        .auto-style14 {
            position: absolute;
            top: 391px;
            left: 496px;
            z-index: 1;
            width: 168px;
            height: 28px;
        }
        .auto-style17 {
            position: absolute;
            top: 434px;
            left: 487px;
            z-index: 1;
            width: 103px;
            height: 29px;
        }
        .auto-style18 {
            position: absolute;
            top: 387px;
            left: 709px;
            z-index: 1;
            width: 279px;
            height: 29px;
        }
        .auto-style19 {
            position: absolute;
            top: 429px;
            left: 700px;
            z-index: 1;
            width: 279px;
            height: 29px;
        }
        .auto-style20 {
            position: absolute;
            top: 670px;
            left: 653px;
            z-index: 1;
            width: 138px;
            height: 47px;
        }
        .auto-style21 {
            position: absolute;
            top: 664px;
            left: 824px;
            z-index: 1;
            width: 138px;
            height: 47px;
        }
        .auto-style22 {
            position: absolute;
            top: 539px;
            left: 611px;
            z-index: 1;
            width: 58px;
            height: 22px;
        }
        .auto-style23 {
            position: absolute;
            top: 488px;
            left: 493px;
            z-index: 1;
            width: 202px;
            height: 28px;
        }
        .auto-style24 {
            position: absolute;
            top: 477px;
            left: 699px;
            z-index: 1;
            width: 279px;
            height: 29px;
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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#009933" CssClass="auto-style1">
            <asp:Label ID="Label5" runat="server" 
    CssClass="auto-style25" Text="Hotel Management" Font-Bold="True" 
                Font-Italic="False" Font-Names="Berlin Sans FB Demi" Font-Overline="False" 
                Font-Size="XX-Large" Font-Strikeout="False" ForeColor="White"></asp:Label>
            <asp:Label ID="Label6" runat="server" CssClass="auto-style13" Font-Bold="True" Font-Names="Berlin Sans FB Demi" Font-Size="X-Large" ForeColor="White" Text="Register"></asp:Label>
            <asp:Label ID="Label8" runat="server" CssClass="auto-style17" Font-Bold="True" Font-Size="X-Large" ForeColor="Green" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style19"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style24"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" CssClass="auto-style21" Font-Size="Large" ForeColor="#666666" Text="Cancel" />
            <asp:Label ID="Label10" runat="server" CssClass="auto-style12" Font-Bold="True" Font-Italic="False" Font-Names="Berlin Sans FB Demi" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" ForeColor="White" Text="DMU BOOKING MANAGEMENT SYSTEM"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="#009933" CssClass="auto-style2">
        </asp:Panel>
        <asp:Image ID="Image1" runat="server" CssClass="auto-style3" 
            ImageUrl="~/hotel.jpg" />
        <asp:Panel ID="Panel3" runat="server" BackColor="#009933" CssClass="auto-style4">
        </asp:Panel>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style5" Font-Size="Large" ForeColor="Green" Text="Every Hotel"></asp:Label>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style6" Font-Size="Large" ForeColor="Green" Text="Quality Guaranty"></asp:Label>
        <asp:Label ID="Label3" runat="server" CssClass="auto-style7" Font-Size="Large" ForeColor="Green" Text="Wonderful Price"></asp:Label>
        <asp:Label ID="Label7" runat="server" CssClass="auto-style14" Font-Bold="True" Font-Size="X-Large" ForeColor="Green" Text="E-Mail Address"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style18"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" CssClass="auto-style20" Font-Size="Large" ForeColor="#666666" Text="Register" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style22"></asp:Label>
        <asp:Label ID="Label9" runat="server" CssClass="auto-style23" Font-Bold="True" Font-Size="X-Large" ForeColor="Green" Text="Confirm Password"></asp:Label>
    </form>
</body>
</html>
