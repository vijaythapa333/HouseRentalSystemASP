using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HouseRentalSystem.classes
{
    public class bookinClass
    {
        public int booking_id { get; set; }
        public int house_id { get; set; }
        public string house_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public DateTime booked_date { get; set; }
    }
}