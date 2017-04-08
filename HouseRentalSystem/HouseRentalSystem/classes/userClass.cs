using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HouseRentalSystem.classes
{
    public class userClass
    {
        public int user_id { get; set; }
        public string full_name { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DateTime addeddate { get; set; }
    }
}