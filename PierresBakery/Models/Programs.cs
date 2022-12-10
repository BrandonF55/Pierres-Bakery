using System;
using PierresBakery;
using System.Collections.Generic;


namespace PierresBakery.Program
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Welcome To Pierre's Baked Goods!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("We Have Freshly Baked Bread And Pastries Available Today!:");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Bread: A Single Loaf Cost $5! Buy Two, Get One Free!\n");
            Console.WriteLine("Pastries: Buy One For $2 Or Three For $5.");
            Console.WriteLine("Would you like to place a order? [Y/y for YES; Press Enter for No]");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            TryAgain();


          static void TryAgain()  
            {

            string userInputOrder = Console.ReadLine().ToUpper();
            if (userInputOrder == "Y")
            {
                int cost = 0;
                
                Console.WriteLine("How Many Loafs Of Bread Would You Like?:");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                int loafsWanted = int.Parse(Console.ReadLine());
                Console.WriteLine("How Many Pastries Would You Like To Purchase?:");
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
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Your Order Is: ");
                    Console.WriteLine($" Bread: {loafsWanted}, Pastries {pastriesWanted}");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($" Your Order Total Is: {cost}");
                    Console.WriteLine("Please Enter Your Payment: ");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                    int paymentResponse = int.Parse(Console.ReadLine());
                    
                    if(paymentResponse == cost)
                    {
                        Console.WriteLine("Thank You For Shopping With Us. I hope You Enjoy Your Freshly Baked Goods!");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    }
                    else 
                    {
                        Console.WriteLine("My Apologies, But That Response You Entered Was Not Valid, Please Try Again.");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        TryAgain();
                    }



                
                }

            }

        }
    }
}