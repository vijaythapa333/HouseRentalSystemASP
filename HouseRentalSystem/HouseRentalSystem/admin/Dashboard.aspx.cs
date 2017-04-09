using HouseRentalSystem.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HouseRentalSystem.admin
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            userDAL Users = new userDAL();
            houseDAL Houses = new houseDAL();
            bookingDAL Bookings = new bookingDAL();

            lblHouses.Text = Houses.TotalHouses().ToString();
            lblUsers.Text = Users.TotalUsers().ToString();
            lblBookings.Text = Bookings.TotalBookings().ToString();
        }
    }
}