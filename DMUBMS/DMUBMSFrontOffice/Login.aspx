<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DMUBMSFrontOffice.Login" %>

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
            top: 25px;
            left: 210px;
            z-index: 1;
            width: 685px;
            height: 42px;
            margin-top: 0px;
        }
        .auto-style13 {
            position: absolute;
            top: 88px;
            left: 460px;
            z-index: 1;
            width: 102px;
            height: 33px;
        }
        .auto-style14 {
            position: absolute;
            top: 406px;
            left: 386px;
            z-index: 1;
            width: 168px;
            height: 28px;
        }
        .auto-style17 {
            position: absolute;
            top: 458px;
            left: 387px;
            z-index: 1;
            width: 103px;
            height: 29px;
        }
        .auto-style18 {
            position: absolute;
            top: 403px;
            left: 595px;
            z-index: 1;
            width: 279px;
            height: 29px;
        }
        .auto-style19 {
            position: absolute;
            top: 456px;
            left: 594px;
            z-index: 1;
            width: 279px;
            height: 29px;
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
            top: 501px;
            left: 394px;
            z-index: 1;
            width: 559px;
            height: 127px;
        }
        .auto-style23 {
            position: absolute;
            top: 656px;
            left: 384px;
            z-index: 1;
            height: 49px;
            width: 124px;
        }
        .auto-style24 {
            position: absolute;
            top: 656px;
            left: 575px;
            z-index: 1;
            height: 49px;
            width: 124px;
        }
        .auto-style26 {
            position: absolute;
            top: 655px;
            left: 751px;
            z-index: 1;
            height: 49px;
            width: 184px;
        }
        .auto-style27 {
            position: absolute;
            top: 193px;
            left: 858px;
            z-index: 1;
            width: 114px;
            height: 48px;
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
            <asp:Label ID="lblLogin" runat="server" CssClass="auto-style13" Font-Bold="True" 
                Font-Names="Berlin Sans FB Demi" Font-Size="X-Large" ForeColor="White" 
                Text="Login"></asp:Label>
            <asp:Label ID="lblEmail" runat="server" CssClass="auto-style14" Font-Bold="True" Font-Size="X-Large" ForeColor="OrangeRed" Text="E-Mail Address"></asp:Label>
            <asp:Label ID="lblPassword" runat="server" CssClass="auto-style17" Font-Bold="True" Font-Size="X-Large" ForeColor="OrangeRed" Text="Password"></asp:Label>
            <asp:TextBox ID="txtEMail" runat="server" CssClass="auto-style18"></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server" CssClass="auto-style19" TextMode="Password"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" CssClass="auto-style22"></asp:Label>
            <asp:Button ID="btnReSend" runat="server" CssClass="auto-style26" Font-Size="Large" ForeColor="#666666" Text="Re-Set Password" OnClick="btnReSend_Click" />
            <asp:Button ID="btnCanel" runat="server" CssClass="auto-style24" Font-Size="Large" ForeColor="#666666" Text="Cancel" OnClick="btnCanel_Click" />
            <asp:Button ID="btnLogin" runat="server" CssClass="auto-style23" Font-Size="Large" ForeColor="#666666" Text="Login" OnClick="Button6_Click" />
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="OrangeRed" CssClass="auto-style2">
        </asp:Panel>
        <asp:Image ID="Image1" runat="server" CssClass="auto-style20" ImageUrl="~/DMUBMS.jpg" />
        <asp:Button ID="btnRegister" runat="server" CssClass="auto-style27" Font-Size="Large" ForeColor="#666666" OnClick="btnRegister_Click" Text="Register" />
    </form>
</body>
</html>
