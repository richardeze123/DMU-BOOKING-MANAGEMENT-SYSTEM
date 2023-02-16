<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FlightRegister.aspx.cs" Inherits="DMUBMSFrontOffice.FlightRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style4 {
            position: absolute;
            top: 194px;
            left: 200px;
            z-index: 1;
            width: 182px;
            height: 175px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#0099FF" ForeColor="#33CC33" style="z-index: 1; left: 8px; top: 29px; position: absolute; height: 144px; width: 843px">
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 188px; top: 9px; position: absolute; width: 504px;" Text="DMU Booking Management System " Font-Bold="True" Font-Size="XX-Large" ForeColor="White"></asp:Label>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="White" style="z-index: 1; left: 334px; top: 50px; position: absolute; width: 166px" Text="Flights"></asp:Label>
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="White" style="z-index: 1; left: 354px; top: 93px; position: absolute; width: 118px; margin-bottom: 7px" Text="Register"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" BackColor="#0099FF" style="z-index: 1; left: 10px; top: 178px; position: absolute; height: 520px; width: 183px; margin-top: 0px">
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" BackColor="#0099FF" style="z-index: 1; left: 10px; top: 704px; position: absolute; height: 136px; width: 867px">
        </asp:Panel>
        <asp:Label ID="lblEmailAddress" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="Large" style="z-index: 1; left: 339px; top: 472px; position: absolute; height: 19px; width: 163px; right: 1008px; margin-top: 0px" Text="Email Address"></asp:Label>
        <asp:TextBox ID="TextBoxEmailAddress" runat="server" style="z-index: 1; left: 579px; top: 469px; position: absolute; width: 309px"></asp:TextBox>
        <asp:Label ID="LabelSurname" runat="server" Font-Bold="True" Font-Size="Larger" style="z-index: 1; left: 338px; top: 418px; position: absolute; width: 117px" Text="Surname"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 582px; top: 417px; position: absolute; width: 308px"></asp:TextBox>
        <asp:Label ID="LabelName" runat="server" Font-Bold="True" Font-Size="Larger" style="z-index: 1; left: 345px; top: 369px; position: absolute; width: 64px; right: 1101px" Text="Name"></asp:Label>
        <asp:Label ID="LabelPassword" runat="server" Font-Bold="True" Font-Size="Larger" style="z-index: 1; left: 339px; top: 518px; position: absolute; width: 112px" Text="Password"></asp:Label>
        <asp:TextBox ID="TextBoxPassword" runat="server" style="z-index: 1; left: 578px; top: 516px; position: absolute; width: 312px"></asp:TextBox>
        <asp:TextBox ID="TextBoxName" runat="server" style="z-index: 1; top: 345px; position: absolute; width: 302px; left: 584px; margin-top: 9px"></asp:TextBox>
        <asp:Label ID="LabelConfirmPassowrd" runat="server" Font-Bold="True" Font-Size="Larger" style="z-index: 1; left: 335px; top: 562px; position: absolute; width: 200px" Text="Confirm Password"></asp:Label>
        <asp:TextBox ID="TextBoxConfirmPassword" runat="server" style="z-index: 1; left: 578px; top: 567px; position: absolute; width: 316px"></asp:TextBox>
        <asp:Button ID="ButtonCancel" runat="server" style="z-index: 1; left: 620px; top: 615px; position: absolute; width: 102px;" Text="Cancel" />
        <asp:Button ID="ButtonRegister" runat="server" style="z-index: 1; left: 426px; top: 617px; position: absolute; width: 116px;" Text="Register" />
        <p>
            &nbsp;</p>
        <asp:Label ID="LabelError" runat="server" style="z-index: 1; left: 534px; top: 676px; position: absolute" Text="lblError"></asp:Label>
        <p>
        <asp:Image ID="Image2" runat="server" CssClass="auto-style4" 
            ImageUrl="~/plane.jpg" />
        </p>
    </form>
</body>
</html>
