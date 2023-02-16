<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefaultHotel.aspx.cs" Inherits="DMUBMSFrontOffice.DefaultHotel" %>

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
        .auto-style26 {
            position: absolute;
            top: 203px;
            left: 511px;
            z-index: 1;
            width: 468px;
            height: 536px;
        }
        .auto-style27 {
            position: absolute;
            top: 433px;
            left: 74px;
            z-index: 1;
            width: 87px;
            height: 38px;
            right: 1324px;
        }
        .auto-style28 {
            position: absolute;
            top: 432px;
            left: 191px;
            z-index: 1;
            width: 87px;
            height: 38px;
        }
        .auto-style29 {
            position: absolute;
            top: 433px;
            left: 312px;
            z-index: 1;
            width: 87px;
            height: 38px;
        }
        .auto-style30 {
            position: absolute;
            top: 367px;
            left: 96px;
            z-index: 1;
            width: 125px;
            height: 38px;
            }
        .auto-style31 {
            position: absolute;
            top: 368px;
            left: 258px;
            z-index: 1;
            width: 125px;
            height: 38px;
        }
        .auto-style22 {
            position: absolute;
            top: 189px;
            left: 4px;
            z-index: 1;
            width: 58px;
            height: 22px;
        }
        .auto-style38 {
            position: absolute;
            top: 262px;
            left: 92px;
            z-index: 1;
            width: 328px;
            height: 21px;
        }
        .auto-style39 {
            position: absolute;
            top: 306px;
            left: 92px;
            z-index: 1;
            width: 279px;
            height: 29px;
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
            <asp:Label ID="lblError" runat="server" CssClass="auto-style22"></asp:Label>
            <asp:TextBox ID="TextBox13" runat="server" CssClass="auto-style39"></asp:TextBox>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="#009933" CssClass="auto-style2">
        </asp:Panel>
        <asp:ListBox ID="ListBox1" runat="server" CssClass="auto-style26"></asp:ListBox>
        <asp:Button ID="Button1" runat="server" CssClass="auto-style28" Font-Size="Large" ForeColor="#666666" Text="Edit" />
        <asp:Button ID="Button2" runat="server" CssClass="auto-style29" Font-Size="Large" ForeColor="#666666" Text="Delete" />
        <asp:Button ID="Button4" runat="server" CssClass="auto-style30" Font-Size="Large" ForeColor="#666666" Text="Apply" />
        <asp:Button ID="Button6" runat="server" CssClass="auto-style31" Font-Size="Large" ForeColor="#666666" Text="Display All" />
        <asp:Button ID="Button5" runat="server" CssClass="auto-style27" Font-Size="Large" ForeColor="#666666" Text="Add" />
        <asp:Label ID="Label16" runat="server" CssClass="auto-style38" Font-Bold="True" Font-Size="X-Large" ForeColor="Green" Text="Please Enter a Phone Number"></asp:Label>
    </form>
</body>
</html>
