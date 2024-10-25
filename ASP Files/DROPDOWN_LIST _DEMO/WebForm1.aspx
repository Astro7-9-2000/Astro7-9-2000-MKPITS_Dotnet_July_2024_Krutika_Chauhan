<!-- 1. <%@ Page ... %>: This is a page directive that provides information about the ASP.NET page.
     2. Language="C#": Specifies that the code-behind for this page is written in C#  
     3. AutoEventWireup="true": This allows ASP.NET to automatically wire up event handlers for events like Page_Load without needing to explicitly declare them in the code-behind file.
     4. CodeBehind="WebForm1.aspx.cs": Specifies the file that contains the code-behind logic for this ASP.NET page.
     5. Inherits="DropDownList.WebForm1": Indicates the fully qualified name of the class that this page inherits from, which is WebForm1 in the DropDownList namespace.-->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DropDownList.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="DropDownList1" runat="server" Height="39px" Width="256px">
            <asp:ListItem Value ="-1" Text = "select City"></asp:ListItem>
            <asp:ListItem Value="1" Selected = "True">Pune</asp:ListItem>
            <asp:ListItem Value="2" Text ="Chennai"></asp:ListItem>
            <asp:ListItem Value="3">Mumbai</asp:ListItem>
            <asp:ListItem Value="4" Enabled = "false">Hyderabad</asp:ListItem>
        </asp:DropDownList>
        <div>
            <asp:Button ID="Submit_Btn" runat="server" Font-Bold="True" Text="Submit" OnClick="Submit_Btn_Click" />
        </div>
    </form>
</body>
</html>
