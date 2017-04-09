<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HouseRentalSystem.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Main Body Starts HERE-->
        <div class="main">
            <div class="wrapper">
                
                
                <!--Contact Detail Entry-->
                <div class="booking-details">
                    <h3>Log In</h3>
                    <asp:Label ID="lblResult" runat="server" ForeColor="Maroon"></asp:Label><br />
                        <span class="name">Username</span>
                        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                        <br />
                        
                        <span class="name">Password</span>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                        <br />
                        
                        &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; 
                        <asp:Button ID="btnLogin" runat="server" Text="Log In" BackColor="#006600" BorderColor="#006600" ForeColor="White" Height="44px" Width="495px" OnClick="btnLogin_Click" />
                        <br />
                        <a href="index.html">Go Home</a>
                </div>
            </div>
        </div>
        <!--Main Body Ends HERE-->
</asp:Content>
