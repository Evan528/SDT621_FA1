using System;

namespace SimpleATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== CTU SIMPLE ATM SYSTEM =====");

          
            Console.Write("Hi, what is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine($"\nWelcome {name}!");

       
            Console.Write("Enter account balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

          
            Console.Write("Enter withdrawal amount: ");
            double withdrawal = Convert.ToDouble(Console.ReadLine());

          
            if (withdrawal <= balance)
            {
                balance -= withdrawal;

                Console.WriteLine("\nWithdrawal successful!");
                Console.WriteLine($"Updated Balance: {balance}");

               
                Console.WriteLine($"Transaction Time: {DateTime.Now}");
            }
            else
            {
                Console.WriteLine("\nInsufficient funds!");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
