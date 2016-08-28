using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data.Product
{
    public class ProductProperty
    {
        public int Id { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ForeignKey("Property")]
        public int PropertyId { get; set; }

        public virtual ProductModel Product { get; set; }
        public virtual ProductProperty Property { get; set; }
    }
}
