<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webform2.aspx.cs" Inherits="ViewState.Webform2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;USERNAME&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtUser" runat="server" BorderColor="Black" Width="420px"></asp:TextBox>
        </div>
        <p>
&nbsp;PASSWORD&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtPass" runat="server" BorderColor="Black" Width="418px"></asp:TextBox>
        </p>
        <asp:Button ID="RestoreBtn" runat="server" Font-Bold="True" OnClick="RestoreBtn_Click" Text="RESTORE" />
    </form>
</body>
</html>
