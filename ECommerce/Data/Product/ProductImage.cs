using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Product
{
    public class ProductImage
    {
        public int Id { get; set; }

        public string ImagePath { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual ProductModel Product { get; set; }
    }
}
