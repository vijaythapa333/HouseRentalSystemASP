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
    public class userDAL
    {
        // ConnectionString to connect to the Database
        static string myconnstr = ConfigurationManager.ConnectionStrings["HouseBookingSystemConnection"].ConnectionString;

        #region ADD User
        public bool AddUser(userClass user)
        {
            //SEt Return Value and set its default value to false
            bool isSuccess = false;

            //Step 1: Databse Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //STep 2: Writing T-SQL
                string sql = "INSERT INTO tbl_user (full_name,username,email,password,added_date) VALUES (@full_name,@username,@email,@password,@added_date)";

                //STep 3: SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Step 4: Pass value to parameters
                cmd.Parameters.AddWithValue("@full_name", user.full_name);
                cmd.Parameters.AddWithValue("@username", user.username);
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@password", user.password);
                cmd.Parameters.AddWithValue("@added_date", user.addeddate);

                //Step 5: Open Connection
                conn.Open();

                //Step 6: Execute Query
                int rows = cmd.ExecuteNonQuery();

                //If the user is added then the value of rows will be greater than 1 else the value of rows will be less than 1
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
        #region Get Total Users
        public int TotalUsers()
        {
            //STep 1: Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            //Create an Integer to return Stock
            int Users = 0;
            DataTable dt = new DataTable();

            try
            {
                //Write TSQL to get all users
                string sql = "SELECT user_id FROM tbl_user";
                //Create SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql,conn);

                //Create SQL Data Adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open Connection
                conn.Open();

                //FIll dt using adapter
                adapter.Fill(dt);
                //Get Total Number of Users from datatable dt
                if(dt.Rows.Count>0)
                {
                    Users = dt.Rows.Count;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                //Close Connection
                conn.Close();
            }

            return Users;
        }
        #endregion
        #region Login
        public bool userLogin(string username, string password)
        {
            //SEt a default return value and its default value to false
            bool isSuccess = false;

            //Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //Step 2: Writing T SQL
                string sql = "SELECT * FROM tbl_user WHERE username=@username and password=@password";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
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
                conn.Close();
            }
            return isSuccess;
        }
        #endregion
    }
}