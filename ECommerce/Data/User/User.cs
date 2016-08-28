using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.Data.User
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }

        public ICollection<UserAddress> Addresses { get; set; }
    }
}