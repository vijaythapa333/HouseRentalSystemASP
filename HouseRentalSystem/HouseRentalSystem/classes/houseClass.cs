using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HouseRentalSystem.classes
{
    public class houseClass
    {
        public int house_id { get; set; }
        public int user_id { get; set; }
        public string house_name { get; set; }
        public string house_location { get; set; }
        public string house_description { get; set; }
        public decimal house_price { get; set; }
        public DateTime added_date { get; set; }
        public string is_active { get; set; }
        public string image_name { get; set; }
    }
}