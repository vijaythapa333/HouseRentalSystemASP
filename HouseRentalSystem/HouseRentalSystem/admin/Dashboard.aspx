<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="HouseRentalSystem.admin.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        
        <!--Main Body Starts HERE-->
        <div class="main">
            <div class="wrapper">
                <h3>Dashboard</h3>
                
                <!--Displaying Recently Added Houses in Boxes-->
                <div class="clearfix">
                    
                    <div class="houses">
                         <h1>1000</h1>
                        <span class="house-title">Houses</span><br />
                        <a href="Houses.aspx">
                            <button type="button" class="btn-book" >View All</button>
                        </a>
                    </div>
                    
                    <div class="houses">
                         <h1>100</h1>
                        <span class="house-title">Users</span><br />
                        <a href="Users.aspx">
                            <button type="button" class="btn-book" >View All</button>
                        </a>
                    </div>

                    <div class="houses">
                         <h1>340</h1>
                        <span class="house-title">Bookings</span><br />
                        <a href="Bookings.aspx">
                            <button type="button" class="btn-book" >View All</button>
                        </a>
                    </div>
                    
                </div>
                
                
            </div>
        </div>
        <!--Main Body Ends HERE-->
</asp:Content>
