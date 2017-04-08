<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="HouseRentalSystem.admin.Users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <!--Main Body Starts HERE-->
        <div class="main">
            <div class="wrapper">
                <div class="book-house">
                    <h2>Users</h2>
                    
                    <!--User Details Here-->
                    
                     <h3>All Users</h3>
                    <a href="AddUser.aspx" runat="server">
                        <button type="button">Add User</button>
                    </a>

                    <asp:GridView ID="GVUsers" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="user_id" DataSourceID="sdsUsers" ForeColor="#333333" GridLines="None" Width="1160px">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                            <asp:BoundField DataField="user_id" HeaderText="user_id" InsertVisible="False" ReadOnly="True" SortExpression="user_id" />
                            <asp:BoundField DataField="full_name" HeaderText="full_name" SortExpression="full_name" />
                            <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                            <asp:BoundField DataField="username" HeaderText="username" SortExpression="username" />
                            <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
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
                    <asp:SqlDataSource ID="sdsUsers" runat="server" ConnectionString="<%$ ConnectionStrings:HouseBookingSystemConnection %>" DeleteCommand="DELETE FROM [tbl_user] WHERE [user_id] = @user_id" InsertCommand="INSERT INTO [tbl_user] ([full_name], [email], [username], [password]) VALUES (@full_name, @email, @username, @password)" SelectCommand="SELECT [user_id], [full_name], [email], [username], [password] FROM [tbl_user] ORDER BY [added_date] DESC" UpdateCommand="UPDATE [tbl_user] SET [full_name] = @full_name, [email] = @email, [username] = @username, [password] = @password WHERE [user_id] = @user_id">
                        <DeleteParameters>
                            <asp:Parameter Name="user_id" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="full_name" Type="String" />
                            <asp:Parameter Name="email" Type="String" />
                            <asp:Parameter Name="username" Type="String" />
                            <asp:Parameter Name="password" Type="String" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="full_name" Type="String" />
                            <asp:Parameter Name="email" Type="String" />
                            <asp:Parameter Name="username" Type="String" />
                            <asp:Parameter Name="password" Type="String" />
                            <asp:Parameter Name="user_id" Type="Int32" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
                </div>
                
               
            </div>
        </div>
        <!--Main Body Ends HERE-->
    </form>
</asp:Content>
