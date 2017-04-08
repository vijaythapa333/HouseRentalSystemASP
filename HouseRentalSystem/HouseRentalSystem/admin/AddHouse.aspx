<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="AddHouse.aspx.cs" Inherits="HouseRentalSystem.admin.AddHouse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Main Body Starts HERE-->
        <div class="main">
            <div class="wrapper">
                
                
                <!--Contact Detail Entry-->
                <div class="booking-details">
                      <form id="form1" runat="server">
                    <h3>Add House</h3>
                          <asp:Label ID="lblImage" runat="server" Text=""></asp:Label>
                          <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                          <br />
                        <span class="name">House Name</span>
                        <asp:TextBox ID="txtHouseName" runat="server" placeholder="Your First Name"></asp:TextBox><br />
                        
                        <span class="name">House Price</span>
                        <asp:TextBox ID="txtHousePrice" runat="server" placeholder="Your Last Name"></asp:TextBox><br />
                        
                        <span class="name">House Location</span>
                        <asp:TextBox ID="txtHouseLocation" runat="server" placeholder="Your E-Mail"></asp:TextBox><br />
                        
                        <span class="name">Description</span>
                        <asp:TextBox ID="txtHouseDescription" runat="server" placeholder="Your Contact Number"></asp:TextBox><br />
                          
                        <span class="name">Is Active</span>
                          <asp:DropDownList ID="ddlIsActive" runat="server" Height="28px" Width="401px">
                              <asp:ListItem>Yes</asp:ListItem>
                              <asp:ListItem>No</asp:ListItem>
                          </asp:DropDownList>
                          <br />

                          <span class="name">Select Image</span>
                          <asp:FileUpload ID="ImageUplad" runat="server" Height="32px" Width="399px" />
                          <br />
                         <span class="name">Image Name</span>
                        <asp:TextBox ID="txtImageName" runat="server" placeholder="Your Contact Number"></asp:TextBox><br />

                          <asp:Button ID="btnAddHouse" runat="server" BackColor="#000066" BorderColor="#000066" ForeColor="White" Height="34px" OnClick="btnAddHouse_Click" Text="Add House" Width="111px" />
                          <br />
                        
                          </div>
                </form>
            </div>
        </div>
        <!--Main Body Ends HERE-->
</asp:Content>
