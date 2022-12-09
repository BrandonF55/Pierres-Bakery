using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;


namespace PierresBakery.TestsTools
{
  [TestClass]
  public class BreadTests
  {
   [TestMethod]
   
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
    Bread loafs  = new Bread(1);
    Assert.AreEqual(typeof(Bread), loafs.GetType());
    }

   }
}
