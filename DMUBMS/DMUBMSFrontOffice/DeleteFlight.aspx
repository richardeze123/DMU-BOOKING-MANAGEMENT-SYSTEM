<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteFlight.aspx.cs" Inherits="DMUBMSFrontOffice.DeleteFlight" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title></title>
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
        <asp:Panel ID="Panel1" runat="server" BackColor="#0099FF" ForeColor="#33CC33" style="z-index: 1; left: 8px; top: 29px; position: absolute; height: 144px; width: 843px">
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 188px; top: 9px; position: absolute; width: 504px;" Text="DMU Booking Management System " Font-Bold="True" Font-Size="XX-Large" ForeColor="White"></asp:Label>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="White" style="z-index: 1; left: 334px; top: 50px; position: absolute; width: 166px" Text="Car Rental"></asp:Label>
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="White" style="z-index: 1; left: 305px; top: 87px; position: absolute; width: 242px; margin-bottom: 7px" Text="Manage Flights"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="#0099FF" style="z-index: 1; left: 10px; top: 178px; position: absolute; height: 520px; width: 183px; margin-top: 0px">
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" BackColor="#0099FF" style="z-index: 1; left: 10px; top: 704px; position: absolute; height: 136px; width: 867px">
        </asp:Panel>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Larger" style="z-index: 1; left: 285px; top: 260px; position: absolute; width: 584px" Text="Are you sure you want to Delete this Flight?"></asp:Label>
        <asp:Button ID="ButtonYes" runat="server" style="z-index: 1; left: 282px; top: 333px; position: absolute; width: 131px;" Text="Yes" />
        <asp:Button ID="ButtonNo" runat="server" style="z-index: 1; left: 603px; top: 327px; position: absolute; width: 130px; margin-top: 4px" Text="No" />
    </form>
</body>
</html>