using ECommerce.Data.Product;
using System.Collections.Generic;

namespace ECommerce.Services.ProductServices
{
    interface IProductService:IServices<ProductModel>
    {
        ProductModel GetProduct(int productId);

        ProductModel GetProduct(string productCode);
        
        List<ProductModel> GetProducts();
      
        



    }
}
