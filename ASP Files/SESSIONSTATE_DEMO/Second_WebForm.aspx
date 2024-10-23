<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Second_WebForm.aspx.cs" Inherits="Session_State.Second_WebForm" %>

<!DOCTYPE html>
<!-- Defines the document as an XHTML document. -->
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Your Page Title</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- PostBackUrl = "~/Third_WebForm.aspx": Specifies the URL to navigate to when the link button is clicked. -->
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Third_WebForm.aspx">GO TO PAGE 3</asp:LinkButton>
        </div>
    </form>
</body>
</html>