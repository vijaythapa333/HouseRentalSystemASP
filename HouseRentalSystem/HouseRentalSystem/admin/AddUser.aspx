<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="HouseRentalSystem.admin.AddUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Main Body Starts HERE-->
        <div class="main">
            <div class="wrapper">
                
                
                <!--Contact Detail Entry-->
                <div class="booking-details">
                      <form id="form1" runat="server">
                    <h3>Add User</h3>
                          <asp:Label ID="lblResult" runat="server" Text=""></asp:Label><br />
                        <span class="name">Full Name</span>
                        <asp:TextBox ID="txtFullName" runat="server" placeholder="Your Full Name"></asp:TextBox><br />
                        
                        <span class="name">Email</span>
                        <asp:TextBox ID="txtEmail" runat="server" placeholder="Your E-Mail"></asp:TextBox><br />
                        
                        <span class="name">Username</span>
                        <asp:TextBox ID="txtUsername" runat="server" placeholder="Your Username"></asp:TextBox><br />

                          <span class="name">Password</span>
                        <asp:TextBox ID="txtPassword" runat="server" placeholder="Your Password"></asp:TextBox><br />

                          <asp:Button ID="btnAddUser" runat="server" BackColor="#000066" BorderColor="#000066" ForeColor="White" Height="34px" Text="Add User" Width="111px" OnClick="btnAddUser_Click" />
                          <br />
                        
                          </div>
                </form>
            </div>
        </div>
        <!--Main Body Ends HERE-->
</asp:Content>
