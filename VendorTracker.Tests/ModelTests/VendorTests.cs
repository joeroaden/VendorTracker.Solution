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
        Vendor newVendor = new Vendor("test vendor name", "test description");
        Assert.AreEqual(typeof(Vendor), newVendor.GetType());
      }

      [TestMethod]
      public void GetName_ReturnNameOfVendor_String()
      {
        Vendor newVendor = new Vendor("test vendor name", "test description");
        string result = newVendor.Name;
        Assert.AreEqual("test vendor name", result);
      }

      [TestMethod]
      public void GetDescription_ReturnDescriptionOfVendor_String()
      {
        Vendor newVendor = new Vendor("test vendor name", "test description");
        string result = newVendor.Description;
        Assert.AreEqual("test description", result);
      }

      [TestMethod]
      public void GetId_ReturnIdOfVendor_Int()
      {
        Vendor newVendor = new Vendor("test vendor name", "test description");
        int result = newVendor.Id;
        Assert.AreEqual(1, result);
      }

      [TestMethod]
      public void VendorConstructor_ReturnsVendorName_VendorName()
      {
        string name = "test vendor name";
        string description = "test description";
        
        Vendor newVendor = new Vendor(name, description);
        Assert.AreEqual(name, newVendor.Name);
      }

      [TestMethod]
      public void GetAll_ReturnsAllVendorObjects_VendorList()
      {
        string name = "test vendor name";
        string description = "test description";
        string name2 = "test vendor name2";
        string description2 = "test description2";
        
        Vendor newVendor = new Vendor(name, description);
        Vendor newVendor2 = new Vendor(name2, description2);
        List<Vendor> newList = new List<Vendor> {newVendor, newVendor2};

        List<Vendor> result = Vendor.GetAll();

        CollectionAssert.AreEqual(newList, result);
      }

      [TestMethod]
      public void Find_ReturnsCorrectVendor_Vendor()
      {
        string name = "test vendor name";
        string description = "test description";
        string name2 = "test vendor name2";
        string description2 = "test description2";

        Vendor newVendor = new Vendor(name, description);
        Vendor newVendor2 = new Vendor(name2, description2);

        Vendor result = Vendor.Find(2);

        Assert.AreEqual(newVendor2, result);
      }

      [TestMethod]
      public void AddOrder_AssociatesOrderWithVendor_OrderList()
      {
        string orderTitle = "testTitle";
        string orderDescription = "testDescription";
        int orderPrice = 10;
        string orderDate = "test date";

        Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
        List<Order> newList = new List<Order> {newOrder};

        string vendorName = "test vendor name";
        string vendorDescription = "test description";
        Vendor newVendor = new Vendor(vendorName, vendorDescription);
        newVendor.AddOrder(newOrder);

        List<Order> result = newVendor.Orders;

        CollectionAssert.AreEqual(newList, result);
      }
    }
}