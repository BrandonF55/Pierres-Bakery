using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Test
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

      [TestMethod]
      public void VendorLocation_ReturnsVendorLocation_string()
      {
      string name = "Brandon's Bakery";
      string location = "first in sandy";
      Vendor newVendor = new Vendor(Name, location);
      string locationCheck = newVendor.location;
      Assert.AreEqual(locationCheck, location);


      }

      

  }
}




