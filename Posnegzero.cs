using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.conditional
{
    class Posnegzero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int num = int.Parse(Console.ReadLine());
            if(num>0)
            {
                Console.WriteLine("number is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("number is negative");
            }
            else
            {
                Console.WriteLine("number is zero");
            }


          //  string ans = num > 0 ? "number is positive" : num < 0 ? "number is negative" : "number is zero";
          //  Console.WriteLine(ans);
        }
    }
}
