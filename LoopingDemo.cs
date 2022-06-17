using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.looping
{
    class LoopingDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number for table");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n+" * "+i+" = "+(i*n));
            }
        }
    }
    class Loop1to10
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Loop35to75
    {
        static void Main(string[] args)
        {
            for(int i = 35; i <= 75; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Loop125to85
    {
        static void Main(string[] args)
        {
            for (int i = 125; i >= 75; i--)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Odd25to45
    {
        static void Main(string[] args)
        {
            for (int i = 25; i <= 45; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);  
                }
               
            }
        }
    }
    class Count1to20
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum * i;
                }

            }
            Console.WriteLine("sum of odd numbers = " + sum);
        }

    }

    class Factevensum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    fact = fact * i;
                }

            }
            Console.WriteLine("factorial of all even numbers = "+fact);
        }


    }

}
