using ECommerce.Data.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.Data.Order
{
    public class Order : IIntEntity
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public string PaymentMode { get; set; }
        public string TransID { get; set; }
        public double Amount { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("UserAddress")]
        public int UserAddressId { get; set; }
        public virtual UserAddress UserAddress { get; set; }

    }
}