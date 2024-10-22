<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="ViewState.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 178px;
        }
        .auto-style3 {
            width: 178px;
            height: 45px;
        }
        .auto-style4 {
            height: 45px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table cellpadding="3" cellspacing="3" class="auto-style1">
                <tr>
                    <td class="auto-style2">USERNAME</td>
                    <td>
                        <asp:TextBox ID="Txt_User" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">PASSWORD</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TxtPass" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="Submit_Btn" runat="server" Font-Bold="True" Height="37px" OnClick="Submit_Btn_Click" Text="SUBMIT" Width="103px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="RestoreBtn" runat="server" Font-Bold="True" Height="37px" OnClick="RestoreBtn_Click" Text="RESTORE" Width="111px" />
                    </td>
                </tr>
            </table>
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
