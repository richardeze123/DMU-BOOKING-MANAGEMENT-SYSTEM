<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActivateAccount.aspx.cs" Inherits="DMUBMSFrontOffice.ActivateAccount" %>

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
            top: 25px;
            left: 210px;
            z-index: 1;
            width: 685px;
            height: 42px;
            margin-top: 0px;
        }
        .auto-style13 {
            position: absolute;
            top: 90px;
            left: 412px;
            z-index: 1;
            width: 206px;
            height: 33px;
        }
        .auto-style20 {
            position: absolute;
            top: 342px;
            left: 17px;
            z-index: 1;
            height: 225px;
            width: 267px;
        }
        .auto-style22 {
            position: absolute;
            top: 470px;
            left: 466px;
            z-index: 1;
            width: 427px;
            height: 78px;
        }
        .auto-style23 {
            position: absolute;
            top: 683px;
            left: 779px;
            z-index: 1;
            height: 49px;
            width: 124px;
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
            <asp:Label ID="lblActivateAccount" runat="server" CssClass="auto-style13" Font-Bold="True" 
                Font-Names="Berlin Sans FB Demi" Font-Size="X-Large" ForeColor="White" 
                Text="Activate Account"></asp:Label>
            <asp:Label ID="lblError" runat="server" CssClass="auto-style22"></asp:Label>
            <asp:Button ID="btnLogin" runat="server" CssClass="auto-style23" Font-Size="Large" ForeColor="#666666" Text="Login" OnClick="Button6_Click" />
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="OrangeRed" CssClass="auto-style2">
        </asp:Panel>
        <asp:Image ID="Image1" runat="server" CssClass="auto-style20" ImageUrl="~/DMUBMS.jpg" />
    </form>
</body>
</html>
