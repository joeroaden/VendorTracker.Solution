using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests //: IDisposable
  {

    // public void Dispose()
    // {
    //   Item.ClearAll();
    // }

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
      Assert.AreEqual(11, newOrder.Price);
    }
  }
}