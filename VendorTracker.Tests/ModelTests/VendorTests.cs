using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
    [TestClass]
    public class VendorTests : IDisposable
    {
        public void Dispose()
        {
            Vendor.ClearAll();
        }

        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("Test Vendor");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            string name = "Test Vendor";
            Vendor newVendor = new Vendor(name);
            string result = newVendor.Name;
            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void GetId_ReturnsId_Int()
        {
            string name = "Test Vendor";
            Vendor newVendor = new Vendor(name);
            int result = newVendor.Id;
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetAll_ReturnsAllVendorObjects_VendorList()
        {
            string name01 = "Test Vendor 1";
            string name02 = "Test Vendor 2";
            Vendor newVendor1 = new Vendor(name01);
            Vendor newVendor2 = new Vendor(name02);
            List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
            List<Vendor> result = Vendor.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }
    }
}