using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.conditional
{
    class Gnumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the third number");
            int num3 = int.Parse(Console.ReadLine());
            /* if (num1 > num2 && num1 > num3)
             {
                 Console.WriteLine(" greatest number is " + num1);
             }
             else if (num2 > num3 && num2 > num1)
             {
                 Console.WriteLine(" greatest number is "+num2);
             }
             else
             {
                 Console.WriteLine(" greatest number is "+num3);
             }*/

            //using ternary operator
            string r = (num1 > num2) ? (num1 > num3) ? "num1 is greater" : "num3 is greater" : (num2 > num3) ? "num2 is greater" : "num3 is greater";
            Console.WriteLine(r);
        }

    }
}
