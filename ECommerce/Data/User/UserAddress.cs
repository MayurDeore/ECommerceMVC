using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.Data.User
{
    public class UserAddress
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}