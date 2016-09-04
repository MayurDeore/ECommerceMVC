using ECommerce.Data.Order;
using ECommerce.Services;
using ECommerce.Services.OrderServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ECommerce.Test.OrderTest
{
    [TestClass]
    public class OrderServiceTest
    {
        [TestMethod]
        public void TestGetByCode()
        {
           
            var mockSet = new Mock<DbSet<Order>>();


            ////Arrange
            var orderObj = new Order
            {
                Amount = 100,
                Date = DateTime.Now,
                Id = 1,
                PaymentMode = "Cash",
                Quantity = 2,
                Status = "Ordered",
                TransID = "ORD001"

            };
            var orders = new List<Order>
            {
                orderObj
            }.AsQueryable();
            mockSet.As<IQueryable<Order>>().Setup(m => m.Provider).Returns(orders.Provider);
            mockSet.As<IQueryable<Order>>().Setup(m => m.Expression).Returns(orders.Expression);
            mockSet.As<IQueryable<Order>>().Setup(m => m.ElementType).Returns(orders.ElementType);
            mockSet.As<IQueryable<Order>>().Setup(p => p.GetEnumerator()).Returns(orders.GetEnumerator());

            var mockContext = new Mock<DBContext>();
            mockContext.Setup(m => m.Set<Order>()).Returns(mockSet.Object);



            var service = new OrderService(mockContext.Object);



            ////Act
            var result = service.GetByTransId("ORD001");

            ////Assert
            Assert.AreEqual(orderObj, result);

        }
    }
}
