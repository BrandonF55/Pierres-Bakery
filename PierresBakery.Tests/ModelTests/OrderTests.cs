using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{

[TestClass]
public class OrderTests : IDisposable 
{
  public void Dispose()
  {
    // Order.ClearAll();
  }


  [TestMethod]
  public void OrderConstructor_TestsInstanceOfOrder_Order()
  {
    Order newOrder = new Order ("item", "amount", "Price", "date");
    Assert.AreEqual(typeof(Order), newOrder.GetType());
  }


}
}



