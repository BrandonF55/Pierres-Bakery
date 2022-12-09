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

    [TestMethod]

    public void BreadConstructor_CreatesCountOfBread_Bread()
      {
        int Counter = 1;
        Bread loafs = new Bread(Counter);
        Assert.AreEqual(Counter, loafs.Counter);

      }
    

   }
}
