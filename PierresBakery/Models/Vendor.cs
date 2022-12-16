using System.Collections.Generic;
// using PierresBakery.Models

namespace PierresBakery.Models 
{

  public class Vendor
  {
   public static List<Vendor> _instances = new List<Vendor> {};
    string Name { get; set; }
    string Location { get; set; }
    public int Id { get; }
    public List <Order> Orders { get; set; }

    public Vendor(string vendorName, string VendorLocation)
    {
      Name = vendorName;
      Location = VendorLocation;
      _instances.Add(this);
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public void Addorder(Order order)
    {
      Orders.Add(order);
    }
  }


}