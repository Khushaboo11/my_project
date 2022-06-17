using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.DoWhileLooping
{
    class Automorphic
    {
        static void Main(string[] args)
        {
            //5^2=25 (the number is five=the last digit of the number is five)
            //76^2=5776( last two digit are equal to the number)
            Console.WriteLine("enter the number to check automorphic or not");
            int num = int.Parse(Console.ReadLine());
            int sqr = num * num;
            int temp = 0,count=0;
            while (num > 0)
            {

                if ((num % 10) == (sqr % 10))
                {
                    count++; ;
                }
                temp++;
                num = num / 10;
                sqr = sqr / 10;
            }
            if (temp == count)
            {
                Console.WriteLine(" number is automorphic");

            }
            else
            {
                Console.WriteLine("Not automorphic number ");
            }

        }
    }
}
