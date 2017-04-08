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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LatestHouses();
            LuxuryHouses();
        }
        private void LatestHouses()
        {
            List<houseClass> houseList = houseDAL.GetNewHouse();
            if(houseList.Count==0)
            {
                lblHouses.Text = "No House Found";
            }
            StringBuilder sb = new StringBuilder();
            foreach(houseClass house in houseList)
            {
                sb.Append(string.Format(@"
                <div class='houses'>
                        <img src ='../images/house/{4}' runat ='server' />
                        <span class='house-title'>{1}</span><br />
                        <span class='house-added'>Added Date:{2}</span><br />
                        <span class='house-location'>Location: {3}</span><br />
                        <a href = 'Book.aspx?id={0}' >
                            <button type='button' class='btn-book' >Book House</button>
                        </a>
                    </div>
                ", house.house_id, house.house_name, house.added_date, house.house_location, house.image_name));

                 lblHouses.Text = sb.ToString();
            }
        }

        private void LuxuryHouses()
        {
            List<houseClass> houseList = houseDAL.GetluxuriousHouse();
            if (houseList.Count == 0)
            {
                lblLuxuryHouses.Text = "No House Found";
            }
            StringBuilder sb = new StringBuilder();
            foreach (houseClass house in houseList)
            {
                sb.Append(string.Format(@"
                <div class='houses'>
                        <img src ='../images/house/{4}' runat ='server' />
                        <span class='house-title'>{1}</span><br />
                        <span class='house-added'>Price:{2}</span><br />
                        <span class='house-location'>Location: {3}</span><br />
                        <a href = 'Book.aspx?id={0}' >
                            <button type='button' class='btn-book' >Book House</button>
                        </a>
                    </div>
                ", house.house_id, house.house_name, house.house_price, house.house_location, house.image_name));

                lblLuxuryHouses.Text = sb.ToString();
            }
        }
    }
}