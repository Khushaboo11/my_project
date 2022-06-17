using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.conditional
{
    class Switchoddeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            switch (num%2)
            {
                case 0:
                    Console.WriteLine(num+"number is even");
                    break;
                case 1:
                    Console.WriteLine(num+" number is odd");
                    break;

            }


            //using ternary operator
           // string result = (num % 2 == 0) ? "even" : "odd";
           // Console.WriteLine(result);
        }
    }
}
