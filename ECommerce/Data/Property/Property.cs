using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.Data.Property
{
    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isActive { get; set; }
        public bool isDelete { get; set; }

        public Property()
        {
            this.isActive = false;
            this.isDelete = false;
        }

        public ICollection<PropertyValue> Values { get; set; }
    }
}