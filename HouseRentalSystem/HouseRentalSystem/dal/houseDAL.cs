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
    public class houseDAL
    {
        // ConnectionString to connect to the Database
        static string myconnstr = ConfigurationManager.ConnectionStrings["HouseBookingSystemConnection"].ConnectionString;

        #region Add House
        public bool AddHouse(houseClass house)
        {
            //SEt Return Value and set its default value to false
            bool isSuccess = false;

            //Step 1: Databse Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //STep 2: Writing T-SQL
                string sql = "INSERT INTO tbl_house (house_name,house_price,house_location,house_description,added_date,is_active,image_name) VALUES (@house_name,@house_price,@house_location,@house_description,@added_date,@is_active,@image_name)";

                //STep 3: SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql,conn);

                //Step 4: Pass value to parameters
                cmd.Parameters.AddWithValue("@house_name", house.house_name);
                cmd.Parameters.AddWithValue("@house_price", house.house_price);
                cmd.Parameters.AddWithValue("@house_location", house.house_location);
                cmd.Parameters.AddWithValue("@house_description", house.house_description);
                cmd.Parameters.AddWithValue("@added_date", house.added_date);
                cmd.Parameters.AddWithValue("@is_active", house.is_active);
                cmd.Parameters.AddWithValue("@image_name", house.image_name);

                //Step 5: Open Connection
                conn.Open();

                //Step 6: Execute Query
                int rows = cmd.ExecuteNonQuery();

                //If the house is added then the value of rows will be greater than 1 else the value of rows will be less than 1
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
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
        #region set is_active to no
        public bool ActivityChange(int id)
        {
            //SEt Return Value and set its default value to false
            bool isSuccess = false;

            //Step 1: Databse Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //STep 2: Writing T-SQL
                string sql = "UPDATE tbl_house SET is_active='no' WHERE house_id="+id;

                //STep 3: SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Step 4: Pass value to parameters

                //Step 5: Open Connection
                conn.Open();

                //Step 6: Execute Query
                int rows = cmd.ExecuteNonQuery();

                //If the house is added then the value of rows will be greater than 1 else the value of rows will be less than 1
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
        #region Get House by Added DAte
        public static List<houseClass> GetNewHouse()
        {
            //Step 1: Databse Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            //Set the return value
            List<houseClass> list = new List<houseClass>();

            try
            {
                //STep 2: Writing T-SQL to get recent house
                string sql = "SELECT * FROM tbl_house WHERE is_active='yes' ORDER BY added_date DESC";

                //Step 3: Opening Database Connection
                conn.Open();

                //Step 4: Sql Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                //STep 5: Fetching Data

                while(reader.Read())
                {
                    houseClass house = new houseClass
                    {
                        house_id = Convert.ToInt32(reader["house_id"]),
                        house_name=Convert.ToString(reader["house_name"]),
                        house_price=Convert.ToDecimal(reader["house_price"]),
                        house_location=Convert.ToString(reader["house_location"]),
                        image_name=Convert.ToString(reader["image_name"]),
                        added_date=Convert.ToDateTime(reader["added_date"])
                    };
                    list.Add(house);
                }


            }
            catch(Exception ex)
            {

            }
            finally
            {
                //STep 8: CLose Connection
                conn.Close();
            }

            return list;
        }
        #endregion
        #region Get Lusurious Houses Price Greater Than 2lakh
        public static List<houseClass> GetluxuriousHouse()
        {
            //Step 1: Databse Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            //Set the return value
            List<houseClass> list = new List<houseClass>();

            try
            {
                //STep 2: Writing T-SQL to get recent house
                string sql = "SELECT * FROM tbl_house WHERE house_price>200000.00 AND is_active='yes'";

                //Step 3: Opening Database Connection
                conn.Open();

                //Step 4: Sql Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                //STep 5: Fetching Data

                while (reader.Read())
                {
                    houseClass house = new houseClass
                    {
                        house_id = Convert.ToInt32(reader["house_id"]),
                        house_name = Convert.ToString(reader["house_name"]),
                        house_price = Convert.ToDecimal(reader["house_price"]),
                        house_location = Convert.ToString(reader["house_location"]),
                        image_name = Convert.ToString(reader["image_name"]),
                        added_date = Convert.ToDateTime(reader["added_date"])
                    };
                    list.Add(house);
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                //STep 8: CLose Connection
                conn.Close();
            }

            return list;
        }
        #endregion
        #region Get House Details By ID
        public static List<houseClass> GetHouseDetails(int id)
        {
            //STep 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            //Creating list to return value
            List<houseClass> list = new List<houseClass>();

            try
            {
                //Step 2: Writing T-SQL to get house details
                string sql = "SELECT * FROM tbl_house WHERE house_id=" + id;

                //STep 3: Opening Connection
                conn.Open();

                //Step 4: Sql Command using sql conn and query
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                //Step 5: Fetching Data
                while(reader.Read())
                {
                    houseClass house = new houseClass()
                    {
                        house_id=Convert.ToInt32(reader["house_id"]),
                        house_name=Convert.ToString(reader["house_name"]),
                        house_price=Convert.ToDecimal(reader["house_price"]),
                        house_location=Convert.ToString(reader["house_location"]),
                        house_description=Convert.ToString(reader["house_description"]),
                        added_date=Convert.ToDateTime(reader["added_date"]),
                        is_active=Convert.ToString(reader["is_active"]),
                        image_name=Convert.ToString(reader["image_name"])
                    };
                    list.Add(house);
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                //STep 8: CLose Connection
                conn.Close();
            }

            return list;
        }
        #endregion
        #region Get House Name by ID
        //public string GetHouseNameByID (int ID)
        //{
        //    SqlConnection conn = new SqlConnection(myconnstr);
        //    string HouseName;
        //}
        #endregion
        #region Get Total Houses
        public int TotalHouses()
        {
            //STep 1: Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            //Create an Integer to return Stock
            int Houses = 0;
            DataTable dt = new DataTable();

            try
            {
                //Write TSQL to get all users
                string sql = "SELECT house_id FROM tbl_house";
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
                    Houses = dt.Rows.Count;
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

            return Houses;
        }
        #endregion
    }
}