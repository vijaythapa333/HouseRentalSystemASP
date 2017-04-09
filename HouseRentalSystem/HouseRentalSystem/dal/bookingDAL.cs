using HouseRentalSystem.classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HouseRentalSystem.dal
{
    public class bookingDAL
    {
        // ConnectionString to connect to the Database
        static string myconnstr = ConfigurationManager.ConnectionStrings["HouseBookingSystemConnection"].ConnectionString;

        #region Add Booking
        public bool AddBooking(bookinClass booking)
        {
            //SEt Return Value and set its default value to false
            bool isSuccess = false;

            //Step 1: Databse Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //STep 2: Writing T-SQL
                string sql = "INSERT INTO tbl_booking (house_id,first_name,last_name,email,contact,address,booked_date) VALUES (@house_id,@first_name,@last_name,@email,@contact,@address,@booked_date);";

                //STep 3: SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Step 4: Pass value to parameters
                cmd.Parameters.AddWithValue("@house_id", booking.house_id);
                cmd.Parameters.AddWithValue("@first_name", booking.first_name);
                cmd.Parameters.AddWithValue("@last_name", booking.last_name);
                cmd.Parameters.AddWithValue("@email", booking.email);
                cmd.Parameters.AddWithValue("@contact", booking.contact);
                cmd.Parameters.AddWithValue("@address", booking.address);
                cmd.Parameters.AddWithValue("@booked_date", booking.booked_date);

                //Step 5: Open Connection
                conn.Open();

                //Step 6: Execute Query
                int rows = cmd.ExecuteNonQuery();

                //If the booking is added then the value of rows will be greater than 1 else the value of rows will be less than 1
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //Step 7: Close Connection
                conn.Close();
            }
            return isSuccess;
        }
        #endregion
        #region Get Total Bookings
        public int TotalBookings()
        {
            //STep 1: Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            //Create an Integer to return Stock
            int Bookings = 0;
            DataTable dt = new DataTable();

            try
            {
                //Write TSQL to get all users
                string sql = "SELECT booking_id FROM tbl_booking";
                //Create SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create SQL Data Adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open Connection
                conn.Open();

                //FIll dt using adapter
                adapter.Fill(dt);
                //Get Total Number of Users from datatable dt
                if (dt.Rows.Count > 0)
                {
                    Bookings = dt.Rows.Count;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //Close Connection
                conn.Close();
            }

            return Bookings;
        }
        #endregion
    }
}