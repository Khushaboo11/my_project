using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.Assignment29_05
{
    class NumPattern
    {
        static void Main(string[] args)
        {
            int i, j,k;
            for (i = 1; i <= 5; i++)
            {

                for (j = i; j <= 5; j++)
                {
                    Console.Write(" ");
                }


                for (k = 1; k <= i; k++)
                {
                    Console.Write(i);
                }
                for (int l = 2; l <= i; l++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    class StarSpace
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 5; k >= i; k--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
    class Numeric
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                int c = 1;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 5; k >= i; k--)
                {
                    Console.Write(c);
                    c++;
                }
                Console.WriteLine();
            }
        }
    }
    class Happy
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 5)
                {
                    if (j == 2)
                    {
                        break;
                        Console.WriteLine(j);
                    }
                    j++;
                }
                Console.WriteLine(i);
            }

        }
    }
}
