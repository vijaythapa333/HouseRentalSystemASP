<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="Bookings.aspx.cs" Inherits="HouseRentalSystem.admin.Bookings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <!--Main Body Starts HERE-->
        <div class="main">
            <div class="wrapper">
                <div class="book-house">
                    <h3>All Bookings</h3>
                    
                    <!--Booking Details Here-->
                    <asp:GridView ID="GVBookings" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="booking_id" DataSourceID="sdsBookings" ForeColor="#333333" GridLines="None" style="margin-right: 414" Width="1155px">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                            <asp:BoundField DataField="booking_id" HeaderText="booking_id" InsertVisible="False" ReadOnly="True" SortExpression="booking_id" />
                            <asp:BoundField DataField="house_id" HeaderText="house_id" SortExpression="house_id" />
                            <asp:BoundField DataField="first_name" HeaderText="first_name" SortExpression="first_name" />
                            <asp:BoundField DataField="last_name" HeaderText="last_name" SortExpression="last_name" />
                            <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                            <asp:BoundField DataField="contact" HeaderText="contact" SortExpression="contact" />
                            <asp:BoundField DataField="address" HeaderText="address" SortExpression="address" />
                            <asp:BoundField DataField="booked_date" HeaderText="booked_date" SortExpression="booked_date" />
                        </Columns>
                        <EditRowStyle BackColor="#999999" />
                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                    </asp:GridView>

                    <asp:SqlDataSource ID="sdsBookings" runat="server" ConnectionString="<%$ ConnectionStrings:HouseBookingSystemConnection %>" DeleteCommand="DELETE FROM [tbl_booking] WHERE [booking_id] = @booking_id" InsertCommand="INSERT INTO [tbl_booking] ([house_id], [first_name], [last_name], [email], [contact], [address], [booked_date]) VALUES (@house_id, @first_name, @last_name, @email, @contact, @address, @booked_date)" SelectCommand="SELECT [booking_id], [house_id], [first_name], [last_name], [email], [contact], [address], [booked_date] FROM [tbl_booking] ORDER BY [booked_date] DESC" UpdateCommand="UPDATE [tbl_booking] SET [house_id] = @house_id, [first_name] = @first_name, [last_name] = @last_name, [email] = @email, [contact] = @contact, [address] = @address, [booked_date] = @booked_date WHERE [booking_id] = @booking_id">
                        <DeleteParameters>
                            <asp:Parameter Name="booking_id" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="house_id" Type="Int32" />
                            <asp:Parameter Name="first_name" Type="String" />
                            <asp:Parameter Name="last_name" Type="String" />
                            <asp:Parameter Name="email" Type="String" />
                            <asp:Parameter Name="contact" Type="String" />
                            <asp:Parameter Name="address" Type="String" />
                            <asp:Parameter Name="booked_date" Type="DateTime" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="house_id" Type="Int32" />
                            <asp:Parameter Name="first_name" Type="String" />
                            <asp:Parameter Name="last_name" Type="String" />
                            <asp:Parameter Name="email" Type="String" />
                            <asp:Parameter Name="contact" Type="String" />
                            <asp:Parameter Name="address" Type="String" />
                            <asp:Parameter Name="booked_date" Type="DateTime" />
                            <asp:Parameter Name="booking_id" Type="Int32" />
                        </UpdateParameters>
                    </asp:SqlDataSource>

                </div>
                
                
                
            </div>
        </div>
        <!--Main Body Ends HERE-->
    </form>
</asp:Content>
