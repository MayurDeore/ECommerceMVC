using ECommerce.Data.Category;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Data.Product
{
    public class ProductModel
    {
        private ICollection<ProductImage> _productImages;
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string FrontImage { get; set; }
        public string ProductCode { get; set; }
        public bool isActive { get; set; }
        public bool isDeleted { get; set; }
        public string Description { get; set; }
        [ForeignKey("SubCategory")]
        public int SubCategoryID { get; set; }
        [ForeignKey("Brand")]
        public int BrandID { get; set; }

        public virtual SubCategory SubCategory { get; set; }

        public virtual Brand.Brand Brand { get; set; }

        public virtual ICollection<ProductImage> Images
        {
            get { return _productImages ?? (_productImages = new List<ProductImage>()); }
            protected set { _productImages = value; }

        }

    }
}
