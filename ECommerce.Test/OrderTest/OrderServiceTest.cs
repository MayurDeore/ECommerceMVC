using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECommerce.Services.OrderServices;
using Moq;
using ECommerce.Data.Order;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using ECommerce.Data;
using ECommerce.Data.User;

namespace ECommerce.Test.OrderTest
{
    [TestClass]
    public class OrderServiceTest
    {
        [TestMethod]
        public void TestGetByCode()
        {
            var context = new TestContext();
            Guid orderId=Guid.NewGuid();
            var service = new OrderService(context);
            var orderObj = new Order
            {
                Amount = 100,
                Date = DateTime.Now,
                Id =1,
                PaymentMode = "Cash",
                Quantity = 2,
                Status = "Ordered",
                TransID = "ORD001"

            };
            context.Orders.Add(orderObj);
            var orderService = new OrderService(context);

            var result = orderService.GetByTransId("ORD001");


            Assert.AreEqual(orderObj,result);

        }
    }
}
