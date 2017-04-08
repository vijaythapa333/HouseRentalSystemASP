using HouseRentalSystem.classes;
using HouseRentalSystem.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HouseRentalSystem.admin
{
    public partial class AddUser : System.Web.UI.Page
    {
        userClass user = new userClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            //Getting Values from UI
            user.full_name = txtFullName.Text;
            user.username = txtUsername.Text;
            user.email = txtEmail.Text;
            user.password = txtPassword.Text;
            user.addeddate = DateTime.Now;

            //Object for DAL
            userDAL dal = new userDAL();
            bool succes = dal.AddUser(user);
            if(succes==true)
            {
                lblResult.Text = "User successfully added.";
                Clear();
            }
            else
            {
                lblResult.Text = "Failed to add user";
            }
        }
        #region Clean TExt Fields after success
        private void Clear()
        {
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
        #endregion
    }
}