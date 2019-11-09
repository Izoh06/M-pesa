using System;
using System.Threading.Channels;

namespace Mpesa
{
    public static class WithdrawCash
    {
        private static void Agent()
        {
            Console.WriteLine("Enter agent number");
            int agentno = Convert.ToInt32(Console.ReadLine());
            AmountPin.AmtPin();
        }
        
        private static void Atm()
        {
            Console.WriteLine("Enter agent number");
            int atmagentno = Convert.ToInt32(Console.ReadLine());
            AmountPin.AmtPin();
        }
        public static void Withdraw()
        {
            Console.WriteLine("1: from agent");
            Console.WriteLine("2: from ATM");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Agent();
                    break;
                case 2:
                    Atm();
                    break;
                default:
                    Console.WriteLine("INVALID INPUT! Try again later");
                    break;
            }
        }
        
    }
}