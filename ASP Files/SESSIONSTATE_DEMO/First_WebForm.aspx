<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="First_WebForm.aspx.cs" Inherits="Session_State.First_WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 194px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table cellpadding="3" cellspacing="4" class="auto-style1">
                <tr>
                    <td class="auto-style2">USERNAME</td>
                    <td>
                        <asp:TextBox ID="TxtUser" runat="server" Width="225px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="Submit_Btn" runat="server" Font-Bold="True" OnClick="Submit_Btn_Click" Text="SUBMIT" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
