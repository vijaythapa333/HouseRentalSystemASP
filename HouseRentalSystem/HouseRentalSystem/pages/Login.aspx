<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HouseRentalSystem.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Main Body Starts HERE-->
        <div class="main">
            <div class="wrapper">
                
                
                <!--Contact Detail Entry-->
                <div class="booking-details">
                    <h3>Log In</h3>
                    <form>
                        <span class="name">Username</span>
                        <input type="text" name="username" placeholder="Username Please" required="true" /><br />
                        
                        <span class="name">Password</span>
                        <input type="password" name="password" placeholder="Password Please" required="true" /><br />
                        
                        <input type="submit" name="submit" placeholder="LOG IN" />
                        <input type="reset" name="reset" placeholder="RESET" /><br />
                        <a href="index.html">Go Home</a>
                    </form>
                </div>
            </div>
        </div>
        <!--Main Body Ends HERE-->
</asp:Content>
