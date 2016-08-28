using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.Data.Property
{
    public class PropertyValue
    {

        public int Id { get; set; }
        public string Value { get; set; }
        public bool isActive { get; set; }
        public bool isDelete { get; set; }
        public PropertyValue()
        {
            this.isActive = false;
            this.isDelete = false;
        }
    }
}