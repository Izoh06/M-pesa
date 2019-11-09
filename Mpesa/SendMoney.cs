using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;

namespace Mpesa
{
    public class SendMoney: IMpesa
    {
        
        public static void Send()
        {
            Phone:
            Console.WriteLine("Enter phone number");
            int phone = Convert.ToInt32(Console.ReadLine());
//            IEnumerable<int> numbers = Enumerable.Range(0700000000, 0799999999);
//            {
//                
//            }
            /*Console.WriteLine("Enter Amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Pin");
            int inputpin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Send KSH "+amount+" to"+phone+" MPESA PIN"+inputpin+"?");*/
            AmountPin.AmtPin();


        }

       // public int Pin { get; set; }


        
    }
}