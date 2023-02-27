<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteHotel.aspx.cs" Inherits="DMUBMSFrontOffice.DeleteHotel" %>

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
            top: 287px;
            left: 18px;
            z-index: 1;
            width: 87px;
            height: 38px;
            right: 1380px;
        }
        .auto-style28 {
            position: absolute;
            top: 286px;
            left: 136px;
            z-index: 1;
            width: 87px;
            height: 38px;
        }
        .auto-style38 {
            position: absolute;
            top: 225px;
            left: 18px;
            z-index: 1;
            width: 470px;
            height: 21px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#009933" CssClass="auto-style1">
            <asp:Label ID="lblHotelManagement" runat="server" 
    CssClass="auto-style25" Text="Hotel Management" Font-Bold="True" 
                Font-Italic="False" Font-Names="Berlin Sans FB Demi" Font-Overline="False" 
                Font-Size="XX-Large" Font-Strikeout="False" ForeColor="White"></asp:Label>
            <asp:Label ID="lblManageHotels" runat="server" CssClass="auto-style13" Font-Bold="True" Font-Names="Berlin Sans FB Demi" Font-Size="X-Large" ForeColor="White" Text="Manage Hotels"></asp:Label>
            <asp:Label ID="lbldmubms" runat="server" CssClass="auto-style12" Font-Bold="True" Font-Italic="False" Font-Names="Berlin Sans FB Demi" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" ForeColor="White" Text="DMU BOOKING MANAGEMENT SYSTEM"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="#009933" CssClass="auto-style2">
        </asp:Panel>
        <asp:Button ID="btnNo" runat="server" CssClass="auto-style28" Font-Size="Large" ForeColor="#666666" Text="No" OnClick="btnNo_Click" />
        <asp:Button ID="btnYes" runat="server" CssClass="auto-style27" Font-Size="Large" ForeColor="#666666" Text="Yes" OnClick="btnYes_Click" />
        <asp:Label ID="lblHotelNo" runat="server" CssClass="auto-style38" Font-Bold="True" Font-Size="X-Large" ForeColor="Green" Text="Are you sure you want to delete this Hotel?"></asp:Label>
    </form>
</body>
</html>
