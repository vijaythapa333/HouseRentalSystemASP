<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="HouseRentalSystem.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--SLIDER STARTS HERE-->
        <div class="slider">
            <div class="wrapper">
                <!-- Start WOWSlider.com BODY section -->
                <div id="wowslider-container1">
                <div class="ws_images"><ul>
                		<li><img src="~/assets/slider/data1/images/house03.jpg" runat="server" alt="House Rental System" title="House Rental System" id="wows1_0"/></li>
                		<li><img src="~/assets/slider/data1/images/pexelsphoto186077.jpg" runat="server"  alt="jquery carousel" title="Luxury Houses for Rent" id="wows1_1"/></li>
                		<li><img src="~/assets/slider/data1/images/39f6e0639465c7e01eaa79e26ada2a48.jpg" runat="server" alt="Rent Houses at Affordable Price" title="Rent Houses at Affordable Price" id="wows1_2"/></li>
                	</ul></div>
                	<div class="ws_bullets"><div>
                		<a href="#" title="House Rental System"><span><img src="~/assets/slider/data1/tooltips/house03.jpg" runat="server" alt="House Rental System"/>1</span></a>
                		<a href="#" title="Luxury Houses for Rent"><span><img src="~/assets/slider/data1/tooltips/pexelsphoto186077.jpg" runat="server" alt="Luxury Houses for Rent"/>2</span></a>
                		<a href="#" title="Rent Houses at Affordable Price"><span><img src="~/assets/slider/data1/tooltips/39f6e0639465c7e01eaa79e26ada2a48.jpg" runat="server" alt="Rent Houses at Affordable Price"/>3</span></a>
                	</div></div>
                <div class="ws_shadow"></div>
                </div>	
                <script type="text/javascript" src="../assets/slider/engine1/wowslider.js"></script>
                <script type="text/javascript" src="../assets/slider/engine1/script.js"></script>
                <!-- End WOWSlider.com BODY section -->
            </div>
        </div>
        <!--SLIDER ENDS HERE-->
        
        <!--Main Body Starts HERE-->
        <div class="main">
            <div class="wrapper">
                <h3>Recently Added</h3>
                
                <!--Displaying Recently Added Houses in Boxes-->
                <div class="clearfix">
                    
                    <asp:Label ID="lblHouses" runat="server" Text=""></asp:Label>
                    
                    
                </div>
                
                <h3>Luxurious Houses</h3>
                <!--Displaying Luxurious Houses in Boxes-->
                <div class="clearfix">
                    
                    <asp:Label ID="lblLuxuryHouses" runat="server" Text=""></asp:Label>
                    
                    
                </div>
            </div>
        </div>
        <!--Main Body Ends HERE-->
</asp:Content>
