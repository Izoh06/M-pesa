using System;
using System.Net;
using System.Net.NetworkInformation;

namespace Mpesa
{
    public class AmountPin
    {
        public static void AmtPin()
        {
            Console.WriteLine("Enter Amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Pin");
            int inputpin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1 to confirm or 2 to cancel");
            int confirm = Convert.ToInt32(Console.ReadLine());
            if (confirm == 1)
            {
                if (inputpin == Account.Pin)
                {
                    Console.WriteLine("Transaction Successful!");
                }
                else
                {
                    Console.WriteLine("WRONG PIN!");
                }
                
            }
            else if (confirm == 2)
            {
                Console.WriteLine("You have successfully cancelled the transaction!");
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
            }
        }
    }
    public class Account
    {
        public const int Pin = 1234;
        public const int Balance = 10000;
    }
    class Program
    {
       public static void Main(string[] args)
       {
           Options:
            Console.WriteLine("  MPESA SYSTEM  ");
            Console.WriteLine("Choose an Option");
            Console.WriteLine("1: Send Money");
            Console.WriteLine("2: Withdraw Cash");
            Console.WriteLine("3: Buy Airtime");
            Console.WriteLine("4: Lipa na M-Pesa");
            Console.WriteLine("5: My Account");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    SendMoney.Send();
                    break;
                case 2:
                    WithdrawCash.Withdraw();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5: 
                    break;
                default:
                    Console.WriteLine("Invalid Option! Please try again!");
                    goto Options;
            }
        }
    }
}