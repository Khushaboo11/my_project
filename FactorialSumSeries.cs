using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.DoWhileLooping
{
    class FactorialSumSeries
    {
        static void Main(string[] args)
        {
            //factorial=1!+2!+3!+4!+5!+.......+n!
            Console.WriteLine("enter the terms you want add the sum of factorial");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            
            for (int i = 1; i <= n; i++)
            {
                int fact = 1;
                for (int j = 1; j <= i; j++)
                {
                    fact = fact * j;
                }

                Console.WriteLine("factorial of " + i + " = " + fact);
                sum = sum + fact;
            }

            Console.WriteLine(" factorail sum = "+sum);
            

        }
    }
}
