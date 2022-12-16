using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Test
{


  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("testing", "testing");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }


      // string name = " Brandon's Bakery";
      // string location = "first in sandy"
      // Vendor newVendor = new Vendor(name, location)

  }
}




