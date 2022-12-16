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
    string Date = "october 30th 2022";
    Order newOrder = new Order(Item, Amount, Price, Date);
    string itemCheck = newOrder.Item;
    Assert.AreEqual(itemCheck, Item);
  }

  [TestMethod]
  public void OrderAmount_ReturnsOrderAmount_string()
  {
    string Item = "Bread";
    string Amount = "69 loafs";
    string Price = "$55";
    string Date = "october 30th 2022";
    Order newOrder = new Order(Item, Amount, Price, Date);
    string amountCheck = newOrder.Amount;
    Assert.AreEqual(amountCheck, Amount);
  }
  
   [TestMethod]
  public void OrderPrice_ReturnsOrderPrice_string()
  {
    string Item = "Bread";
    string Amount = "69 loafs";
    string Price = "$55";
    string Date = "october 30th 2022";
    Order newOrder = new Order(Item, Amount, Price, Date);
    string priceCheck = newOrder.Price;
    Assert.AreEqual(priceCheck, Price);
  }




}
}



