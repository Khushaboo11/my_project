using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.conditional
{
    class Leapyear

    {


        static void Main(string[] args)
        {
            Console.WriteLine("enter any year");
            int year = int.Parse(Console.ReadLine());
            if(year%400==0)
            {
                Console.WriteLine(year+" is a leap year");
            }
            else if(year%4==0)
            {
                Console.WriteLine(year+" is a leap year");
            }
            else
            {
                Console.WriteLine(year+"is not a leap year");
            }
        }
    }
}
