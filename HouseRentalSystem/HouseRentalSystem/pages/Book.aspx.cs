using HouseRentalSystem.classes;
using HouseRentalSystem.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HouseRentalSystem
{
    public partial class Book : System.Web.UI.Page
    {
        private int id;
        //private string house_name;
        bookinClass book = new bookinClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            HouseDetails();
        }
        private void HouseDetails()
        {
            id = Convert.ToInt32(Request.QueryString["id"]);//Getting Values from URL

            List<houseClass> houseDetail = houseDAL.GetHouseDetails(id);
            if(houseDetail.Count==1)
            {
                StringBuilder sb = new StringBuilder();
                foreach(houseClass house in houseDetail)
                {
                    sb.Append(string.Format(@"
                    <h3>{0}</h3>
                    
                    <!--House Details Here-->
                     <img src='../images/house/{5}' runat='server' />
                    <span class='house-added'>Added Date: {4}/span><br />
                    <span class='house-location'>Location: {2}</span><br />
                    <span class='house-price'>Price: NRS {1}</span>
                    <p>
                        {3}
                    </p>
                    ", house.house_name, house.house_price, house.house_location, house.house_description, house.added_date, house.image_name));

                   lblHouseDetail.Text = sb.ToString();
                }
            }
            else
            {
                lblHouseDetail.Text = "Invalid House ID";
            }
        }

        protected void btnBook_Click(object sender, EventArgs e)
        {
            //Get VAlues from UI
            book.house_id = id;
            book.first_name = txtFirstName.Text;
            book.last_name = txtLastName.Text;
            book.email = txtEmail.Text;
            book.contact = txtContact.Text;
            book.address = txtAddress.Text;
            book.booked_date = DateTime.Now;

            //Object for DAL
            bookingDAL dal = new bookingDAL();
            bool success = dal.AddBooking(book);
            if(success==true)
            {
                //Update Booking Table and set is_active to no
                houseDAL housedal = new houseDAL();
                bool change = housedal.ActivityChange(id);
                if(change==true)
                {
                    lblUpdate.Text = "Updated.";
                }
                else
                {
                    lblUpdate.Text = "Update Failed.";
                }
                lblBook.Text = "Your House Successfully Booked.";
                Clear();
            }
            else
            {
                lblBook.Text = "Failed to book your house.";
            }
        }
        private void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
        }
    }
}