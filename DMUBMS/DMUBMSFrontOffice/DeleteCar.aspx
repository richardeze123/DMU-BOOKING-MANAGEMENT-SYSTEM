<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteCar.aspx.cs" Inherits="DMUBMSFrontOffice.DeleteCar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>DMUBMS</title>
    <style type="text/css">

        .auto-style5 {
            position: absolute;
            top: 551px;
            left: 210px;
            z-index: 1;
            height: 135px;
            width: 276px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="Red" ForeColor="#33CC33" style="z-index: 1; left: 8px; top: 29px; position: absolute; height: 144px; width: 843px">
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 188px; top: 9px; position: absolute; width: 545px;" Text="DMU Booking Management System " Font-Bold="True" Font-Size="XX-Large" ForeColor="White" Font-Names="berlin sans fb demi, xx-large"></asp:Label>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="White" style="z-index: 1; left: 334px; top: 50px; position: absolute; width: 166px" Text="Car Rental" Font-Names="berlin sans fb demi, xx-large"></asp:Label>
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="White" style="z-index: 1; left: 317px; top: 91px; position: absolute; width: 200px; margin-bottom: 7px" Text="Manage Cars" Font-Names="Berlin Sans FB Demi,XX-Large"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="Red" style="z-index: 1; left: 10px; top: 178px; position: absolute; height: 520px; width: 183px; margin-top: 0px">
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" BackColor="Red" style="z-index: 1; left: 10px; top: 704px; position: absolute; height: 136px; width: 867px">
        </asp:Panel>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Larger" style="z-index: 1; left: 208px; top: 226px; position: absolute; width: 584px" Text="Are you sure you want to Delete this Car?"></asp:Label>
        <asp:Button ID="ButtonYes" runat="server" style="z-index: 1; left: 232px; top: 310px; position: absolute" Text="Yes" />
        <asp:Button ID="ButtonNo" runat="server" style="z-index: 1; left: 296px; top: 308px; position: absolute; width: 36px; margin-top: 4px" Text="No" />
    </form>
</body>
</html>

