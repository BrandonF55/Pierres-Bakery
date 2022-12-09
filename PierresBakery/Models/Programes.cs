using System;
using PierresBakery;
using System.Collections.Generic;


namespace PierresBakery
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Welcome To Pierre's Baked Goods!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("We have Bread and Pastries available today!: ");
            Console.WriteLine("Bread: A single loaf cost $5. Buy 2, get 1 free!");
            Console.WriteLine("Pastries: Buy 1 for $2 or 3 for $5.");
            Console.WriteLine("Would you like to place a order? [Y/y for YES; Press Enter for No]");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            string userInputOrder = Console.WriteLine().ToUpper();
            if (userInputOrder == "Y")
            {
                int cost = 0;
                Console.WriteLine("How many loafs of bread would you like?:");
                int loafsWanted = int.parse(Console.ReadLine());
                Console.WriteLine("How many pastries would you like to purchase?:");
                int pastriesWanted = int.pase(Console.ReadLine());

                Bread loafs = new Bread(loafsWanted);
                Pastery item = new Pastery(pastriesWanted);
                cost = (loafs.Counter * loafs.Price) + (item.Counter * item.Price);

                    if(loafs.Counter % 3 == 0)
                    {
                        cost -= (loafs.Counter/3) * 5;
                    }

                    if (item.Counter % == 0);
                    {
                        cost -= (cake.Counter/3);
                    }



                


            }




        }
    }
}