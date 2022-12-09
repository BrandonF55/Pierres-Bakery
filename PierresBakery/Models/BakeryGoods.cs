using System;
using PierresBakery;

namespace PierresBakery
{
    public class Bread
    {
      public int Price { get; set; }
      public int Counter { get; set; }

      public Bread (int counter)
      {
        Price = 5;
        Counter = counter;
      }
    }
        
     public class Pastery
     {
        public int Price { get; set; }
        public int Counter { get; set; }

        public Pastery(int counter)
        {
            Price = 2;
            Counter = counter;
        }
     }
}

    
