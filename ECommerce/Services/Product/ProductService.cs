

using ECommerce.Data;
using ECommerce.Data.Product;
using System;
using System.Linq;

namespace ECommerce.Services.Product
{
    public class ProductService : EntityService<ProductModel>,IService
    {

        
        public ProductService(DBContext context):base(context)
        {

        }


        public ProductModel GetByCode(string code)
        {
            return base.GetAll().Where(p => p.Code == code).FirstOrDefault();
        }
        
    }
}
