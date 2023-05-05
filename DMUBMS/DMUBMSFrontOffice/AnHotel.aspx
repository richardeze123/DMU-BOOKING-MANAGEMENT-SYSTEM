<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnHotel.aspx.cs" Inherits="DMUBMSFrontOffice.AnHotel" %>

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
            top: 372px;
            left: 15px;
            z-index: 1;
            width: 241px;
            height: 28px;
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
            top: 459px;
            left: 179px;
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
            <asp:Label ID="lblStarRating" runat="server" CssClass="auto-style32" Font-Bold="True" Font-Size="X-Large" ForeColor="Green" Text="Star Rating"></asp:Label>
            <asp:Label ID="lblHotelName" runat="server" CssClass="auto-style23" Font-Bold="True" Font-Size="X-Large" ForeColor="Green" Text="Hotel Name"></asp:Label>
            <asp:Label ID="lblHotelAddress" runat="server" CssClass="auto-style34" Font-Bold="True" Font-Size="X-Large" ForeColor="Green" Text="Hotel Address"></asp:Label>
            <asp:Label ID="lblDateAdded" runat="server" CssClass="auto-style36" Font-Bold="True" Font-Size="X-Large" ForeColor="Green" Text="Date Added"></asp:Label>
            <asp:Label ID="lblRoomsAvailable" runat="server" CssClass="auto-style35" Font-Bold="True" Font-Size="X-Large" ForeColor="Green" Text="Rooms Available"></asp:Label>
            <asp:Label ID="lblPhoneNumber" runat="server" CssClass="auto-style33" Font-Bold="True" Font-Size="X-Large" ForeColor="Green" Text="Phone Number"></asp:Label>
        </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#009933" CssClass="auto-style1">
            <asp:Label ID="lblHotelManagement" runat="server" 
    CssClass="auto-style25" Text="Hotel Management" Font-Bold="True" 
                Font-Italic="False" Font-Names="Berlin Sans FB Demi" Font-Overline="False" 
                Font-Size="XX-Large" Font-Strikeout="False" ForeColor="White"></asp:Label>
            <asp:Label ID="lblManageHotels" runat="server" CssClass="auto-style13" Font-Bold="True" Font-Names="Berlin Sans FB Demi" Font-Size="X-Large" ForeColor="White" Text="Manage Hotels"></asp:Label>
            <asp:Label ID="Label10" runat="server" CssClass="auto-style12" Font-Bold="True" Font-Italic="False" Font-Names="Berlin Sans FB Demi" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" ForeColor="White" Text="DMU BOOKING MANAGEMENT SYSTEM"></asp:Label>
            <asp:Label ID="lblError" runat="server" CssClass="auto-style22"></asp:Label>
            <asp:TextBox ID="txtHotelName" runat="server" CssClass="auto-style42"></asp:TextBox>
            <asp:TextBox ID="txtStarRating" runat="server" CssClass="auto-style24" OnTextChanged="txtStarRating_TextChanged"></asp:TextBox>
            <asp:TextBox ID="txtDateAdded" runat="server" CssClass="auto-style44"></asp:TextBox>
            <asp:TextBox ID="txtHotelAddress" runat="server" CssClass="auto-style41" OnTextChanged="txtHotelAddress_TextChanged"></asp:TextBox>
            <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="auto-style40"></asp:TextBox>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="#009933" CssClass="auto-style2">
        </asp:Panel>
        <asp:Button ID="btnCancel" runat="server" CssClass="auto-style28" Font-Size="Large" ForeColor="#666666" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnOk" runat="server" CssClass="auto-style27" Font-Size="Large" ForeColor="#666666" Text="OK" OnClick="btnOk_Click" />
        <asp:CheckBox ID="chkActive" runat="server" CssClass="auto-style37" Font-Bold="True" Font-Size="X-Large" ForeColor="Green" Text="Active" />
        <asp:DropDownList ID="ddlRoomsAvailable" runat="server" CssClass="auto-style45">
        </asp:DropDownList>
    </form>
</body>
</html>
