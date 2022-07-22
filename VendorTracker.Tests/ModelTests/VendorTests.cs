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
      Assert.AreEqual("test description", result);
    }
    }
}