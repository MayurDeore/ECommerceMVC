using ECommerce.Data.Product;
using System.Collections.Generic;

namespace ECommerce.Data.Brand
{
    public class Brand
    {
        private ICollection<ProductModel> _product;

        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public string BrandCode { get; set; }
        public bool isActive { get; set; }
        public bool isDeleted { get; set; }

        public Brand()
        {
            isActive = false;
            isDeleted = false;
        }


        public virtual ICollection<ProductModel> products
        {
            get { return _product ?? (_product = new List<ProductModel>()); }
            protected set { _product = value; }
        }
    }
}