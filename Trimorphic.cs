using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.Assignment29_05
{
    class Trimorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number to check given number is Trimorphic or not");
            int num = int.Parse(Console.ReadLine());
            int cube = num * num * num;
            int temp = 0, count = 0;
            while (num > 0)
            {

                if ((num % 10) == (cube % 10))
                {
                    count++;
                }
                temp++;
                num = num / 10;
                cube = cube / 10;
            }
            if (temp == count)
            {
                Console.WriteLine(" number is Trimorphic");

            }
            else
            {
                Console.WriteLine("Not Trimorphic number ");
            }
        }
    }
}
