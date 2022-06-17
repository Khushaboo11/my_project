using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.basic_fundamentals
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ener the two values to swap using third variable");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int d = a, e = b;
            Console.WriteLine(" values before swapping"+a+" "+b);
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine(" values after swapping"+a+" "+b);

            Console.WriteLine("swapping without using third variable");
            d = d + e;
            e = d - e;
            d = d - e;
            Console.WriteLine("after swapping "+d+" "+e);
            

        }
    }
}
