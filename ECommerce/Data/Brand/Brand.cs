using ECommerce.Data.Product;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Data.Brand
{
    public class Brand
    {
        private ICollection<ProductModel> _product;
        [Key]
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string BrandCode { get; set; }
        [ScaffoldColumn(false)]
        public bool isActive { get; set; }
        [ScaffoldColumn(false)]
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