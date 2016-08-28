using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.Data.Category
{
    public class Category
    {
        private ICollection<SubCategory> _subcategory;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool isActive { get; set; }
        public bool isDeleted { get; set; }

        public Category()
        {
            isActive = false;
            isDeleted = false;

        }
        
        public virtual ICollection<SubCategory> SubCategories
        {
            get { return _subcategory ?? (_subcategory = new List<SubCategory>()); }
            protected set { _subcategory = value; }
        }
    }
}