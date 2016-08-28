using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.Data.Category
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public bool isActive { get; set; }
        public bool isDeleted { get; set; }

        public SubCategory()
        {
            isActive = false;
            isDeleted = false;

        }
    }
}