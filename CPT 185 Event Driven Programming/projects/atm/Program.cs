using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double balance = 1000.00;
            double depositAmount = 0.00;
            double withdrawAmount = 0.00;

            Console.WriteLine("==== Welcome To Mini ATM ====");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");

            Console.Write("Choose an option : ");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            while (userChoice != 4)
            {
                if (userChoice == 1)
                {
                    Console.WriteLine("==== Welcome To Mini ATM ====");
                    Console.WriteLine("Account Balance : " + balance);
                    break;
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("==== Welcome To Mini ATM ====");
                }
            }

            

        }
    }
}
