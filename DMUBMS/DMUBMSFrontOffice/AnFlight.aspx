<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnFlight.aspx.cs" Inherits="DMUBMSFrontOffice.AnFlight" %>

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
            top: 695px;
            left: 78px;
            z-index: 1;
            width: 87px;
            height: 38px;
            right: 1320px;
        }
        .auto-style28 {
            position: absolute;
            top: 695px;
            left: 199px;
            z-index: 1;
            width: 87px;
            height: 38px;
        }
        .auto-style23 {
            position: absolute;
            top: 192px;
            left: 14px;
            z-index: 1;
            width: 241px;
            height: 28px;
        }
        .auto-style32 {
            position: absolute;
            top: 262px;
            left: 15px;
            z-index: 1;
            width: 217px;
            height: 28px;
        }
        .auto-style33 {
            position: absolute;
            top: 334px;
            left: 16px;
            z-index: 1;
            width: 229px;
            height: 28px;
            margin-top: 0px;
        }
        .auto-style34 {
            position: absolute;
            top: 401px;
            left: 15px;
            z-index: 1;
            width: 231px;
            height: 28px;
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
            top: 518px;
            left: 17px;
            z-index: 1;
            width: 91px;
            height: 31px;
        }
        .auto-style22 {
            position: absolute;
            top: 555px;
            left: 8px;
            z-index: 1;
            width: 522px;
            height: 117px;
        }
        .auto-style24 {
            position: absolute;
            top: 251px;
            left: 182px;
            z-index: 1;
            width: 279px;
            height: 29px;
        }
        .auto-style40 {
            position: absolute;
            top: 319px;
            left: 180px;
            z-index: 1;
            width: 279px;
            height: 29px;
        }
        .auto-style41 {
            position: absolute;
            top: 392px;
            left: 182px;
            z-index: 1;
            width: 279px;
            height: 29px;
        }
        .auto-style42 {
            position: absolute;
            top: 181px;
            left: 184px;
            z-index: 1;
            width: 279px;
            height: 29px;
        }
        .auto-style44 {
            position: absolute;
            top: 459px;
            left: 179px;
            z-index: 1;
            width: 279px;
            height: 29px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblFlightGroup" runat="server" CssClass="auto-style32" Font-Bold="True" Font-Size="X-Large" ForeColor="Blue" Text="Flight Group"></asp:Label>
            <asp:Label ID="lblFlightName" runat="server" CssClass="auto-style23" Font-Bold="True" Font-Size="X-Large" ForeColor="Blue" Text="Flight Name"></asp:Label>
            <asp:Label ID="lblFlightCompany" runat="server" CssClass="auto-style34" Font-Bold="True" Font-Size="X-Large" ForeColor="Blue" Text="Flight Company"></asp:Label>
            <asp:Label ID="lblDateAdded" runat="server" CssClass="auto-style36" Font-Bold="True" Font-Size="X-Large" ForeColor="Blue" Text="Date Added"></asp:Label>
            <asp:Label ID="lblFlightCode" runat="server" CssClass="auto-style33" Font-Bold="True" Font-Size="X-Large" ForeColor="Blue" Text="Flight Code"></asp:Label>
        </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="Blue" CssClass="auto-style1">
            <asp:Label ID="lblFlightManagement" runat="server" 
    CssClass="auto-style25" Text="Flight Management" Font-Bold="True" 
                Font-Italic="False" Font-Names="Berlin Sans FB Demi" Font-Overline="False" 
                Font-Size="XX-Large" Font-Strikeout="False" ForeColor="White"></asp:Label>
            <asp:Label ID="lblManageFlights" runat="server" CssClass="auto-style13" Font-Bold="True" Font-Names="Berlin Sans FB Demi" Font-Size="X-Large" ForeColor="White" Text="Manage Flights"></asp:Label>
            <asp:Label ID="Label10" runat="server" CssClass="auto-style12" Font-Bold="True" Font-Italic="False" Font-Names="Berlin Sans FB Demi" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" ForeColor="White" Text="DMU BOOKING MANAGEMENT SYSTEM"></asp:Label>
            <asp:Label ID="lblError" runat="server" CssClass="auto-style22"></asp:Label>
            <asp:TextBox ID="txtFlightName" runat="server" CssClass="auto-style42"></asp:TextBox>
            <asp:TextBox ID="txtFlightGroup" runat="server" CssClass="auto-style24"></asp:TextBox>
            <asp:TextBox ID="txtDateAdded" runat="server" CssClass="auto-style44"></asp:TextBox>
            <asp:TextBox ID="txtFlightCompany" runat="server" CssClass="auto-style41"></asp:TextBox>
            <asp:TextBox ID="txtFlightCode" runat="server" CssClass="auto-style40"></asp:TextBox>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="Blue" CssClass="auto-style2">
        </asp:Panel>
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style28" Font-Size="Large" ForeColor="#666666" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnOk" runat="server" CssClass="auto-style27" Font-Size="Large" ForeColor="#666666" Text="OK" OnClick="btnOk_Click" />
        <asp:CheckBox ID="chkActive" runat="server" CssClass="auto-style37" Font-Bold="True" Font-Size="X-Large" ForeColor="Blue" Text="Active" />
    </form>
</body>
</html>
