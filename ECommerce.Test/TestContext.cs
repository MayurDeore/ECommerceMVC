using ECommerce.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Data.Order;
using System.Data.Entity;
using ECommerce.Data.Brand;

namespace ECommerce.Test
{
    public class TestContext : IDBContext
    {
        public TestContext()
        {
            this.Orders = new TestDbSet<Order>();
        }

        public IDbSet<Brand> Brands
        {
            get;
            set;
        }

        public IDbSet<Order> Orders { get; set; }

       
    }
}
