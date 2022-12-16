using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;

namespace PierresBakery.Controllers
{

  public class VendorController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResults Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allvendors);
    }

    [HttpGet("vendor/new")]
    public ActionResults new()
    {
      return View():
    }

     [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorLocation)
    {
      Vendor newVendor = new Vendor(vendorName, vendorLocation);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId/orders}")]
    public ActionResult Create(int vendorId, string orderItem, string orderAmount, string orderPrice, string orderDate)
    {
      Dicionary<string, object> model = new Dicionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderItem, orderAmount, orderPrice, orderDate);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrder = foundVendor.Orders;
      model.Add("orders", vendorOrder);
      modle.Add("vendor", foundVendor);
      return View("show", model);

    }
  }
}

