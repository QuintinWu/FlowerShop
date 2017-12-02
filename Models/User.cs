using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlowerShopApp.Models
{
    public class User
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public long Phone { get; set; }
    }
}