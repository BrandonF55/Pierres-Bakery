using System;
using PierresBakery;
using System.Collections.Generic;


namespace PierresBakery.Program
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
            // Console.WriteLine("Would you like to place a order? [Y/y for YES; Press Enter for No]");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");


          static void TryAgain()  
          
                {
            Console.WriteLine("Would you like to place a order? [Y/y for YES; Press Enter for No]");
            string userInputOrder = Console.WriteLine();//.ToUpper();
            if (userInputOrder == "Y")
            {
                int cost = 0;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("How many loafs of bread would you like?:");
                int loafsWanted = int.Parse(Console.ReadLine());
                Console.WriteLine("How many pastries would you like to purchase?:");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                int pastriesWanted = int.Parse(Console.ReadLine());

                Bread loafs = new Bread(loafsWanted);
                Pastery item = new Pastery(pastriesWanted);
                cost = (loafs.Counter * loafs.Price) + (item.Counter * item.Price);

                    if(loafs.Counter % 3 == 0)
                    {
                        cost -= (loafs.Counter/3) * 5;
                    }

                    if(item.Counter % 3 == 0)
                    {
                        cost -= (item.Counter/3);
                    }

                    Console.WriteLine("Your order is: ");
                    Console.WriteLine($" Bread: {loafsWanted}, Pastries {pastriesWanted}");
                    Console.WriteLine($" Your Order Total is: {cost}");
                    Console.WriteLine("Please enter your Payment: ");

                    int paymentResponse = int.Parse(Console.ReadLine());
                    
                    if(paymentResponse == cost)
                    {
                        Console.WriteLine("Thank you for shopping with us!");
                    }
                    else 
                    {
                        Console.Write("My apologies, but that response was not valid please try again.");
                        TryAgain();
                    }



                
                }

            }




        }
    }
}