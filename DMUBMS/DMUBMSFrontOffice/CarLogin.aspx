<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarLogin.aspx.cs" Inherits="DMUBMSFrontOffice.CarLogin" %>

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
        <asp:Panel ID="Panel1" runat="server" BackColor="Red" ForeColor="#33CC33" style="z-index: 1; left: 8px; top: 29px; position: absolute; height: 144px; width: 843px">
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 188px; top: 9px; position: absolute; width: 504px;" Text="DMU Booking Management System " Font-Bold="True" Font-Size="XX-Large" ForeColor="White"></asp:Label>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="White" style="z-index: 1; left: 334px; top: 50px; position: absolute; width: 166px" Text="Car Rental"></asp:Label>
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="White" style="z-index: 1; left: 354px; top: 93px; position: absolute; width: 99px; margin-bottom: 7px" Text="Login"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="Red" style="z-index: 1; left: 10px; top: 178px; position: absolute; height: 520px; width: 183px; margin-top: 0px">
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" BackColor="Red" style="z-index: 1; left: 10px; top: 704px; position: absolute; height: 136px; width: 867px">
        </asp:Panel>
        <asp:Label ID="lblEmailAddress" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="Large" style="z-index: 1; left: 388px; top: 385px; position: absolute; height: 19px; width: 163px; right: 959px; margin-top: 0px" Text="Email Address"></asp:Label>
        <asp:TextBox ID="TextBoxEmailAddress" runat="server" style="z-index: 1; left: 561px; top: 382px; position: absolute; width: 309px"></asp:TextBox>
        <asp:Label ID="LabelPassword" runat="server" Font-Bold="True" Font-Size="Larger" style="z-index: 1; left: 395px; top: 421px; position: absolute; width: 112px" Text="Password"></asp:Label>
        <asp:TextBox ID="TextBoxPassword" runat="server" style="z-index: 1; left: 562px; top: 432px; position: absolute; width: 312px"></asp:TextBox>
        <asp:Image ID="Image3" runat="server" CssClass="auto-style5" 
            ImageUrl="~/car.jpg" />
        <asp:Button ID="ButtonCancel" runat="server" style="z-index: 1; left: 811px; top: 558px; position: absolute" Text="Cancel" />
        <asp:Button ID="ButtonRegister" runat="server" style="z-index: 1; left: 716px; top: 560px; position: absolute" Text="Register" />
        <p>
            &nbsp;</p>
        <asp:Label ID="LabelError" runat="server" style="z-index: 1; left: 579px; top: 631px; position: absolute" Text="lblError"></asp:Label>
        <p>
            <asp:Button ID="ButtonLogin" runat="server" style="z-index: 1; left: 627px; top: 562px; position: absolute" Text="Login" />
        </p>
    </form>
</body>
</html>

