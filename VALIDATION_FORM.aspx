<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VALIDATION_FORM.aspx.cs" Inherits="VALIDATION_CONTROLS.VALIDATION_FORM" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 204px;
        }
        .auto-style3 {
            width: 204px;
            height: 40px;
        }
        .auto-style4 {
            height: 40px;
        }
        .auto-style5 {
            width: 204px;
            height: 44px;
        }
        .auto-style6 {
            height: 44px;
        }
        .auto-style7 {
            width: 204px;
            height: 38px;
        }
        .auto-style8 {
            height: 38px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>STUDENTS REGISTERATION FORM</h2>

        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style6" colspan="2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" BackColor="Silver" Font-Size="Large" ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">STUDENT NAME</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TxtName" runat="server" Height="30px" Width="348px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtName" ErrorMessage="Please Enter Name" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">STUDENT EMAIL</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TxtEmail" runat="server" Height="30px" Width="348px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtEmail" Display="Dynamic" ErrorMessage="Please Enter Email" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TxtEmail" Display="Dynamic" ErrorMessage="Email is Invalid" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">RE-ENTER EMAIL</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TxtReEnterMail" runat="server" Height="30px" Width="348px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtReEnterMail" ErrorMessage="Please Re-Enter Email" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TxtEmail" ControlToValidate="TxtReEnterMail" Display="Dynamic" ErrorMessage="Email is Not Identical" ForeColor="Red" SetFocusOnError="True">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">CLASS </td>
                <td class="auto-style8">
                    <asp:TextBox ID="TxtClass" runat="server" Height="30px" Width="346px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TxtClass" Display="Dynamic" ErrorMessage="Please Enter Class" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TxtClass" Display="Dynamic" ErrorMessage="Class should be from 1 to 12" ForeColor="Red" MaximumValue="12" MinimumValue="1" SetFocusOnError="True" Type="Integer">*</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">FEES</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TxtFees" runat="server" Height="27px" Width="345px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TxtFees" Display="Dynamic" ErrorMessage="Please Enter Fees" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="TxtFees" ErrorMessage="Fees Should be from 2000.00 to 5000.00" ForeColor="Red" MaximumValue="5000.00" MinimumValue="2000.00" SetFocusOnError="True" Type="Double">*</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="SubmitBtn" runat="server" Font-Bold="True" Height="34px" OnClick="SubmitBtn_Click" Text="Submit" Width="97px" />
                </td>
            </tr>
        </table>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
