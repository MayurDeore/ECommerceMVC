using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Data.Product;
using System.Data.Entity;

namespace ECommerce.Services.ProductServices
{
    public class ProductService : IProductService
    {

        private IDBContext _context;
        private DbSet<ProductModel> _product;

        public ProductService(IDBContext context)
        {
            this._context = context;
            this._product = this._context.Set<ProductModel>();
        }
        public ProductModel GetProduct(string productCode)
        {
            return this._product
                .Where(x => x.ProductCode == productCode).FirstOrDefault();
        }

        public ProductModel GetProduct(int productId)
        {
            return this._product
                .Where(x => x.Id == productId).FirstOrDefault();
        }

        public List<ProductModel> GetProducts()
        {
            return this._product.ToList();
        }

        
    }
}
