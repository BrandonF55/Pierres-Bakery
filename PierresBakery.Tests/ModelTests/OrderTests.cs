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

  [TestMethod]
  public void OrderItem_ReturnsOrdersItem_string()
  {
    string Item = "Bread";
    string Amount = "69 loafs";
    string Price = "$55";
    string Date = "october";
    Order newOrder = new Order(Item, Amount, Price, Date);
    string ItemCheck = newOrder.Item;
    Assert.AreEqual(ItemCheck, Item);
  }

  





}
}



