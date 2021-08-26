using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartOpsAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public string Token { get; set; }

        public int IsVisible { get; set; }
        public DateTime DateCreated { get; set; }
        public string ImageUrl { get; set; }


    }
}
