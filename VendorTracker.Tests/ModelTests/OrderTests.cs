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
      Order newOrder = new Order("testTitle", "testDescription", 10, "testDate");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_Order()
    {
      Order newOrder = new Order("testTitle", "testDescription", 10, "testDate");
      Assert.AreEqual("testTitle", newOrder.Title);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_Order()
    {
      Order newOrder = new Order("testTitle", "testDescription", 10, "testDate");
      Assert.AreEqual("testDescription", newOrder.Description);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Order()
    {
      Order newOrder = new Order("testTitle", "testDescription", 10, "testDate");
      Assert.AreEqual(10, newOrder.Price);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_Order()
    {
      Order newOrder = new Order("testTitle", "testDescription", 10, "testDate");
      Assert.AreEqual("testDate", newOrder.Date);
    }

    [TestMethod]
    public void OrderConstructor_SetTitle_string()
    {
      Order newOrder = new Order("testTitle", "testDescription", 10, "testDate");
      newOrder.Title = "newTestTitle";
      Assert.AreEqual("newTestTitle", newOrder.Title);
    }
    [TestMethod]
    public void OrderConstructor_SetAllProperties_string()
    {
      Order newOrder = new Order("testTitle", "testDescription", 10, "testDate");
      newOrder.Title = "newTestTitle";
      newOrder.Description = "newTestDescription";
      newOrder.Price = 11;
      newOrder.Date = "newTestDate";
      Assert.AreEqual("newTestTitle", newOrder.Title);
      Assert.AreEqual("newTestDescription", newOrder.Description);
      Assert.AreEqual(11, newOrder.Price);
      Assert.AreEqual("newTestDate", newOrder.Date);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> newResult = Order.GetAll();
      CollectionAssert.AreEqual(newList, newResult);
    }

  }
}
