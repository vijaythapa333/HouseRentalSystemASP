using HouseRentalSystem.classes;
using System;
using System.Collections.Generic;
using System.Configuration;
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
    }
}