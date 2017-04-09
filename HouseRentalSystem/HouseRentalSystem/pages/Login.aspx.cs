using HouseRentalSystem.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HouseRentalSystem
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            userDAL dal = new userDAL();
            //GEt Values from UI
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool isSuccess = dal.userLogin(username,password);
            if(isSuccess==true)
            {
                //Login Success
                Session["login"] = username;
                Response.Redirect("~/admin/Dashboard.aspx");
            }
            else
            {
                //Login Fail
                lblResult.Text = "Username or Password or Both invalid. Please Try Again.";
                Response.Redirect("~/pages/Login.aspx");
            }
        }
    }
}