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
      public void BreadConstructor_ReturnsPriceOfBread_Bread()
      {
      int Price = 5;
      Bread loafs = new Bread(1);
      Assert.AreEqual(Price, loafs.Price);
    }

   }

      [TestClass]
      public class PasteryTests
      {

        [TestMethod]
        public void PasteryConstructor_CreatesInstaceOfPastery_Pastry()
        {
          Pastery item = new Pastery(1);
          Assert.AreEqual(typeof(Pastery), item.GetType());
        }

        [TestMethod] 
        public void PasteryConstructor_CreatesCountOfPastery_Pastry()
        {
          int Counter = 1;
          Pastery item = new Pastery(Counter);
          Assert.AreEqual(Counter, item.Counter);
        }

        [TestMethod]
        public void PasteryConstructor_ReturnsPriceOfPastery_Pastry()
        {
          int Price = 2;
          Pastery item = new Pastery(1);
          Assert.AreEqual(Price, item.Price);
        }
    

        }


}