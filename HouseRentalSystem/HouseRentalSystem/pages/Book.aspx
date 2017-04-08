<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.Master" AutoEventWireup="true" CodeBehind="Book.aspx.cs" Inherits="HouseRentalSystem.Book" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Main Body Starts HERE-->
        <div class="main">
            <div class="wrapper">
                <div class="book-house clearfix">

                    <asp:Label ID="lblHouseDetail" runat="server" Text=""></asp:Label>
                    
                </div>
                
                <!--Client Booking Detail Entry-->
                <div class="booking-details">
                    <h3>Your Booking Details</h3>
                        <asp:Label ID="lblBook" runat="server" Text=""></asp:Label><asp:Label ID="lblUpdate" runat="server" Text=""></asp:Label><br />

                        <span class="name">First Name</span>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox><br />
                        
                        <span class="name">Last Name</span>
                        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox><br />
                        
                        <span class="name">E-Mail</span>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
                        
                        <span class="name">Conatct No.</span>
                        <asp:TextBox ID="txtContact" runat="server"></asp:TextBox><br />
                        
                        <span class="name">Address</span> 
                        <asp:TextBox ID="txtAddress" runat="server" Height="103px" TextMode="MultiLine"></asp:TextBox><br />
                        
                    <asp:Button ID="btnBook" runat="server" Text="Book Now" BackColor="#000066" BorderColor="#000066" ForeColor="White" Height="48px" OnClick="btnBook_Click" Width="592px" />
                </div>
            </div>
        </div>
        <!--Main Body Ends HERE-->
</asp:Content>
