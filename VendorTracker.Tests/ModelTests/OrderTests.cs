using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
    [TestClass]
    public class OrderTests : IDisposable
    {
        public void Dispose()
        {
            Order.ClearAll();
        }

        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order("Test Order");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetDetails_ReturnsDetails_String()
        {
            string details = "40 croissants";
            Order newOrder = new Order(details);
            string result = newOrder.Details;
            Assert.AreEqual(details, result);
        }

        [TestMethod]
        public void SetDetails_SetDetails_String()
        {
            string details = "40 croissants";
            Order newOrder = new Order(details);
            string updatedDetails = "40 bread loaves";
            newOrder.Details = updatedDetails;
            string result = newOrder.Details;
            Assert.AreEqual(updatedDetails, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_ItemList()
        {
            List<Order> newList = new List<Order> { };
            List<Order> result = Order.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }
    }
}