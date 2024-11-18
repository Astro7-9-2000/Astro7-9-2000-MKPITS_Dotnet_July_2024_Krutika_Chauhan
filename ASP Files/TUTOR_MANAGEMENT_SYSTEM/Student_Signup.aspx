<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Site.Master" AutoEventWireup="true" CodeBehind="Student_Signup.aspx.cs" Inherits="TMS_PROJECT.Student_Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <br />
    <div>
        <div class="container" style="box-shadow: -4px 3px 23px 3px rgba(0,0,0,0.75); -webkit-box-shadow: -4px 3px 23px 3px rgba(0,0,0,0.75); -moz-box-shadow: -4px 3px 23px 3px rgba(0,0,0,0.75);">
            <br />
            <div class="row">
                <div class="col-md-12">
                    <h1 class="jumbotron bg-primary text-white text-center">Student SignUp</h1>
                </div>
            </div>

            <div class="row">
                <div class="col-md-3">
                    <asp:TextBox ID="TxtName" CssClass="form-control" placeholder="Enter Name" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate = "TxtName" ForeColor = "Red" SetFocusOnError = "true" Display ="Dynamic" ID = "RequiredFieldValidator" runat = "server" ErrorMessage=" Name is Required"></asp:RequiredFieldValidator>  

                    <br />

                    <asp:TextBox ID="TxtFatherName" CssClass="form-control" placeholder="Enter Father Name" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate = "TxtFatherName" ForeColor = "Red" SetFocusOnError = "true" Display ="Dynamic" ID = "RequiredFieldValidator1" runat = "server" ErrorMessage="Father Name is Required"></asp:RequiredFieldValidator>  

                    <br />

                    <asp:TextBox ID="TxtSurName" CssClass="form-control" placeholder="Enter Surname" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate = "TxtSurName" ForeColor = "Red" SetFocusOnError = "true" Display ="Dynamic" ID = "RequiredFieldValidator2" runat = "server" ErrorMessage="Surname is Required"></asp:RequiredFieldValidator>  

                    <br />

                    <asp:DropDownList ID="GenderDropDownList" CssClass="form-control" runat="server">
                        <asp:ListItem>Select Gender</asp:ListItem>
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator InitialValue = "Select Gender" ControlToValidate = "GenderDropDownList" ForeColor = "Red" SetFocusOnError = "true" Display ="Dynamic" ID = "RequiredFieldValidator3" runat = "server" ErrorMessage="Gender is Required"></asp:RequiredFieldValidator>  
                    <br />

                    <asp:TextBox ID="TxtAge" CssClass="form-control" placeholder="Enter Age" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate = "TxtAge" ForeColor = "Red" SetFocusOnError = "true" Display ="Dynamic" ID = "RequiredFieldValidator4" runat = "server" ErrorMessage=" Age is Required"></asp:RequiredFieldValidator>  
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age should be within 5 to 60" ControlToValidate="TxtAge" Display="Dynamic" ForeColor="Red" MaximumValue="60" MinimumValue="5" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
                    <br />

                    <asp:DropDownList ID="CountryDropDownList" CssClass="form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CountryDropDownList_SelectedIndexChanged">
                        <asp:ListItem>Select Country</asp:ListItem>
                        <asp:ListItem>India</asp:ListItem>
                        <asp:ListItem>Pakistan</asp:ListItem>
                        <asp:ListItem>USA</asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource runat="server" ID="TMS_DB" ConnectionString='<%$ ConnectionStrings:TMS_DBConnectionString %>' ProviderName='<%$ ConnectionStrings:TMS_DBConnectionString.ProviderName %>' SelectCommand="SELECT * FROM [Student_SignUp]"></asp:SqlDataSource>
                    <asp:RequiredFieldValidator InitialValue = "Select Country" ControlToValidate = "CountryDropDownList" ForeColor = "Red" SetFocusOnError = "true" Display ="Dynamic" ID = "RequiredFieldValidator5" runat = "server" ErrorMessage="Country is Required"></asp:RequiredFieldValidator>  
                </div>

                <div class="col-md-4">
                    <asp:DropDownList ID="CityDropDownList" CssClass="form-control" runat="server">
                        <asp:ListItem>Select City</asp:ListItem>
                        <asp:ListItem>Hyderabad</asp:ListItem>
                        <asp:ListItem>Delhi</asp:ListItem>
                        <asp:ListItem>Mumbai</asp:ListItem>
                        <asp:ListItem>Chennai</asp:ListItem>
                        <asp:ListItem>Pune</asp:ListItem>
                        <asp:ListItem>Karachi</asp:ListItem>
                        <asp:ListItem>New York</asp:ListItem>
                        <asp:ListItem>Chicago</asp:ListItem>
                        <asp:ListItem>Ohio</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator InitialValue = "Select City" ControlToValidate = "CityDropDownList" ForeColor = "Red" SetFocusOnError = "true" Display ="Dynamic" ID = "RequiredFieldValidator6" runat = "server" ErrorMessage="City is Required"></asp:RequiredFieldValidator>  
                    <br />

                    <asp:TextBox ID="TxtAddress" TextMode="MultiLine" Rows="4" CssClass="form-control" placeholder="Enter Address" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate = "TxtAddress" ForeColor = "Red" SetFocusOnError = "true" Display ="Dynamic" ID = "RequiredFieldValidator7" runat = "server" ErrorMessage = "Address is Required"></asp:RequiredFieldValidator>  
                    <br />

                    <asp:TextBox ID="TxtClass" CssClass="form-control" placeholder="Enter Class" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate = "TxtClass" ForeColor = "Red" SetFocusOnError = "true" Display ="Dynamic" ID = "RequiredFieldValidator8" runat = "server" ErrorMessage = "Class is Required"></asp:RequiredFieldValidator>  
                    <br />

                    <asp:DropDownList ID="GoingToDropDownList" CssClass="form-control" runat="server">
                        <asp:ListItem>Select Going To</asp:ListItem>
                        <asp:ListItem>School</asp:ListItem>
                        <asp:ListItem>College</asp:ListItem>
                        <asp:ListItem>University</asp:ListItem>
                        <asp:ListItem>Other</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator InitialValue = "Select Going To" ControlToValidate = "GoingToDropDownList" ForeColor = "Red" SetFocusOnError = "true" Display ="Dynamic" ID = "RequiredFieldValidator9" runat = "server" ErrorMessage="Going To is Required"></asp:RequiredFieldValidator>  
                    <br />

                    <asp:TextBox ID="TxtSubject" CssClass="form-control" placeholder="Enter Subject" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="TxtSubject" ForeColor="Red" SetFocusOnError="true" Display="Dynamic" ID="RequiredFieldValidator10" runat="server" ErrorMessage="Subject is Required"></asp:RequiredFieldValidator>  
                </div>
                <br />
                <div class="col-md-4">
                    <asp:TextBox ID="TxtContact" CssClass="form-control" placeholder="Enter Contact" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="TxtContact" ForeColor="Red" SetFocusOnError="true" Display="Dynamic" ID="RequiredFieldValidator12" runat="server" ErrorMessage="Contact is Required"></asp:RequiredFieldValidator>  
                    <br />

                    <asp:DropDownList ID="TutionTypeDropDownList" CssClass="form-control" runat="server">
                        <asp:ListItem>Select Tution Type</asp:ListItem>
                        <asp:ListItem>Online</asp:ListItem>
                        <asp:ListItem>Physical</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator InitialValue = "Select Tution Type" ControlToValidate = "TutionTypeDropDownList" ForeColor = "Red" SetFocusOnError = "true" Display ="Dynamic" ID = "RequiredFieldValidator11" runat = "server" ErrorMessage="Tution Type is Required"></asp:RequiredFieldValidator>  
                    <br />

                    <asp:DropDownList ID="TutionPreferredDropDownList" CssClass="form-control" runat="server">
                        <asp:ListItem>Select Tution Preferred</asp:ListItem>
                        <asp:ListItem>Graduate</asp:ListItem>
                        <asp:ListItem>Masters</asp:ListItem>
                        <asp:ListItem>MPHIL</asp:ListItem>
                        <asp:ListItem>PHD</asp:ListItem>
                        <asp:ListItem>Other</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator InitialValue = "Select Tution Type" ControlToValidate = "TutionTypeDropDownList" ForeColor = "Red" SetFocusOnError = "true" Display ="Dynamic" ID = "RequiredFieldValidator13" runat = "server" ErrorMessage="Tution Preference is Required"></asp:RequiredFieldValidator>  
                    <br />

                    <asp:TextBox ID="TxtUserName" CssClass = "form-control" placeholder = "Enter Username" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="TxtUserName" ForeColor="Red" SetFocusOnError="true" Display="Dynamic" ID="RequiredFieldValidator14" runat="server" ErrorMessage="Username is Required"></asp:RequiredFieldValidator>  
                    <br />

                    <asp:TextBox ID="TxtPassword" CssClass = "form-control" placeholder = "Enter Password" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="TxtPassword" ForeColor="Red" SetFocusOnError="true" Display="Dynamic" ID="RequiredFieldValidator15" runat="server" ErrorMessage="Password is Required"></asp:RequiredFieldValidator>  
                    <asp:RegularExpressionValidator ControlToValidate = "TxtPassword" ID = "RegularExpressionValidator1" ForeColor = "Red" Display ="Dynamic"  runat = "server" ErrorMessage = "Please Enter Strong Password" ValidationExpression = "^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$"></asp:RegularExpressionValidator>
                    <br />

                    <asp:TextBox ID="TxtConfirmPassword" CssClass="form-control" placeholder="Re-Enter Password" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="TxtConfirmPassword" ForeColor="Red" SetFocusOnError="true" Display="Dynamic" ID="RequiredFieldValidator16" runat="server" ErrorMessage="Confirm Password is Required"></asp:RequiredFieldValidator>  
                    <asp:CompareValidator ID="CompareValidator1" ControlToValidate = "TxtConfirmPassword" ControlToCompare = "TxtPassword" ForeColor = "Red" Display = "Dynamic" SetFocusOnError = "true" runat= "server" ErrorMessage = "Both Passwords must be Identical"></asp:CompareValidator>
                </div>
            </div>
            <br />
        <div class="row">

            <div class="col-md-6 mx-auto">
                <asp:Button ID="StudentSignUpButton" OnClick = "StudentSignUpButton_Click" runat="server" Text="Sign Up" CssClass="btn btn-primary btn-block" />
            </div>
        </div>
            <br />
        </div>
        </div>
    <br />
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</asp:Content>
