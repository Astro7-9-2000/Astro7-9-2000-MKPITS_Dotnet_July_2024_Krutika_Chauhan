<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Login.aspx.cs" Inherits="TMS_PROJECT.Admin_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Login</title>
    <link href = "~/assets/vendor/bootstrap/css/bootstrap.min.css" rel = "stylesheet"/>
</head>
<body style = "background-color:whitesmoke;">
    <form id="form1" runat="server">
        <div class = "container">
            <div class = "row">

                <div class = "col-md-4 mx-auto" style = "box-shadow: -4px 3px 23px 3px rgba(0,0,0,0.75);
-webkit-box-shadow: -4px 3px 23px 3px rgba(0,0,0,0.75);
-moz-box-shadow: -4px 3px 23px 3px rgba(0,0,0,0.75);">
                    <div class = "jumbotron text-center text-white bg-primary">
                        <h2>Admin Login</h2>
                    </div>
                    <asp:TextBox ID ="TxtUserName" placeholder = "Enter Username" CssClass = "form-control" runat = "server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate = "TxtUserName"  ForeColor = "Red"  SetFocusOnError = "true" Display = "Dynamic" runat = "server" ErrorMessage="Username is Required"></asp:RequiredFieldValidator>
                    <br />
                    <asp:TextBox ID ="TxtPassword" placeholder = "Enter Password" CssClass = "form-control" runat = "server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate = "TxtPassword"  ForeColor = "Red"  SetFocusOnError = "true" Display = "Dynamic" runat = "server" ErrorMessage="Password is Required"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Button ID="LoginBtn" runat="server" Text="Login" CssClass = "btn btn-primary btn btn-block" OnClick="LoginBtn_Click"/>
                    <br />
                </div>

            </div>

        </div>
    </form>
    <script src = "/assets/vendor/jquery/jquery.min.js"></script>
    <script src = "/assets/vendor/bootstrap/js/bootstrap.min.js"></script>
</body>
</html>
