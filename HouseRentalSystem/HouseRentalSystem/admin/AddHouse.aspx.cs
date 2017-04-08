using HouseRentalSystem.classes;
using HouseRentalSystem.dal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HouseRentalSystem.admin
{
    public partial class AddHouse : System.Web.UI.Page
    {
        houseClass house = new houseClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddHouse_Click(object sender, EventArgs e)
        {
            house.house_name = txtHouseName.Text;
            house.house_price = decimal.Parse(txtHousePrice.Text);
            house.house_location = txtHouseLocation.Text;
            house.house_description = txtHouseDescription.Text;
            house.added_date = DateTime.Now;
            house.is_active = ddlIsActive.SelectedValue.ToString();
            house.image_name = "no-image.jpg";

            //File Upload Starts HEre
            try
            {
                if(ImageUplad.HasFile)
                {
                    //Generating Random Number
                    Random rand = new Random();

                    int guid = rand.Next();
                    string fileName = guid + Path.GetFileName(ImageUplad.FileName);
                    ImageUplad.PostedFile.SaveAs(Server.MapPath("~/images/house/") + fileName);
                    lblImage.Text = "Image " + fileName + " Successfully Uploaded";
                    house.image_name = fileName;
                }
                else
                {
                    lblImage.Text = "No Image Selected";
                }
            }
            catch(Exception ex)
            {
                lblImage.Text = "Failed to upload Image.";
            }
            finally
            {
                
            }
            //Image Upload Ends Here

            //Object for DAL
            houseDAL DAL = new houseDAL();
            bool success = DAL.AddHouse(house);
            if(success==true)
            {
                lblResult.Text = "House Successfully Added.";
                Clear();
            }
            else
            {
                lblResult.Text = "Failed to Add New House.";
            }
        }

        #region Clean After Adding House
        private void Clear()
        {
            txtHouseName.Text = "";
            txtHousePrice.Text = "";
            txtHouseLocation.Text = "";
            txtHouseDescription.Text = "";
        }
        #endregion
    }
}