<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="Houses.aspx.cs" Inherits="HouseRentalSystem.admin.Houses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <!--Main Body Starts HERE-->
        <div class="main">
            <div class="wrapper">
                <div class="book-house">
                    <h2>Houses</h2>
                    
                    <!--House Details Here-->
                     
                    <h3>All Houses</h3>
                    <a href="AddHouse.aspx">
                         <button type="button">Add House</button>
                     </a>
                    <asp:GridView ID="GVHouses" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="house_id" DataSourceID="sdsHouses" ForeColor="#333333" GridLines="None" Width="1158px">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                            <asp:BoundField DataField="house_id" HeaderText="house_id" InsertVisible="False" ReadOnly="True" SortExpression="house_id" />
                            <asp:BoundField DataField="house_name" HeaderText="house_name" SortExpression="house_name" />
                            <asp:BoundField DataField="house_price" HeaderText="house_price" SortExpression="house_price" />
                            <asp:BoundField DataField="house_location" HeaderText="house_location" SortExpression="house_location" />
                            <asp:BoundField DataField="is_active" HeaderText="is_active" SortExpression="is_active" />
                            <asp:BoundField DataField="added_date" HeaderText="added_date" SortExpression="added_date" />
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
                    <asp:SqlDataSource ID="sdsHouses" runat="server" ConnectionString="<%$ ConnectionStrings:HouseBookingSystemConnection %>" DeleteCommand="DELETE FROM [tbl_house] WHERE [house_id] = @house_id" InsertCommand="INSERT INTO [tbl_house] ([house_name], [house_price], [house_location], [is_active], [added_date]) VALUES (@house_name, @house_price, @house_location, @is_active, @added_date)" SelectCommand="SELECT [house_id], [house_name], [house_price], [house_location], [is_active], [added_date] FROM [tbl_house] ORDER BY [added_date] DESC" UpdateCommand="UPDATE [tbl_house] SET [house_name] = @house_name, [house_price] = @house_price, [house_location] = @house_location, [is_active] = @is_active, [added_date] = @added_date WHERE [house_id] = @house_id">
                        <DeleteParameters>
                            <asp:Parameter Name="house_id" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="house_name" Type="String" />
                            <asp:Parameter Name="house_price" Type="Decimal" />
                            <asp:Parameter Name="house_location" Type="String" />
                            <asp:Parameter Name="is_active" Type="String" />
                            <asp:Parameter DbType="Date" Name="added_date" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="house_name" Type="String" />
                            <asp:Parameter Name="house_price" Type="Decimal" />
                            <asp:Parameter Name="house_location" Type="String" />
                            <asp:Parameter Name="is_active" Type="String" />
                            <asp:Parameter DbType="Date" Name="added_date" />
                            <asp:Parameter Name="house_id" Type="Int32" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
                </div>
                
            </div>
        </div>
        <!--Main Body Ends HERE-->
    </form>
</asp:Content>
