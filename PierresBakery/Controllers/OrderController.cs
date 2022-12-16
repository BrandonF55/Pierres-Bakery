using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;

namespace PierresBakery.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResults New( int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/items/{itemId}")]
    public ActionResults show( int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dicionary<stringg, object> model Dicionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }


  }
}