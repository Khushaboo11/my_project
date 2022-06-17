using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.Assignment29_05
{
    class Number
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 100; i++)
            {
                if ((i % 5 != 0) && (i % 10 != 0))
                {
                    Console.Write(i+"  ");
                }
               
            }
        }

       

    }
    class Lazy
    {
        static void Main(string[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            } while (b != 3);

        }
    }
    class Lazzy
    {
        static void Main(string[] args)
        {
            int i = 1, k = 1;
            while (i++ <= 5)
            {
                k *= i;
            }
            Console.WriteLine("k="+k+"i="+i);

        }
    }
    class Smile
    {
        static void Main(string[] args)
        {
            for(int i = 5; i > 0; i--)
            {
                int a = 100;
                a -= i;
                Console.WriteLine(a);
            }
        }
    }
}
