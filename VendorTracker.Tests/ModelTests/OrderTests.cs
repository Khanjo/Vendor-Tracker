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
            string title = "40 croissants";
            Order newOrder = new Order(title);
            string result = newOrder.Title;
            Assert.AreEqual(title, result);
        }

        [TestMethod]
        public void SetDetails_SetDetails_String()
        {
            string title = "40 croissants";
            Order newOrder = new Order(title);
            string updatedTitle = "40 bread loaves";
            newOrder.Title = updatedTitle;
            string result = newOrder.Title;
            Assert.AreEqual(updatedTitle, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_OrderList()
        {
            List<Order> newList = new List<Order> { };
            List<Order> result = Order.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetAll_ReturnsOrders_OrderList()
        {
            string title01 = "40 croissants";
            string title02 = "40 bread loaves";
            Order newOrder1 = new Order(title01);
            Order newOrder2 = new Order(title02);
            List<Order> newList = new List<Order> { newOrder1, newOrder2 };
            List<Order> result = Order.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetId_OrderInstantiateWithAnIdAndGetterReturns_Int()
        {
            string title = "40 croissants";
            Order newOrder = new Order(title);
            int result = newOrder.Id;
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectOrder_Order()
        {
            string title01 = "40 croissants";
            string title02 = "40 bread loaves";
            Order newOrder1 = new Order(title01);
            Order newOrder2 = new Order(title02);
            Order result = Order.Find(2);
            Assert.AreEqual(newOrder2, result);
        }
    }
}