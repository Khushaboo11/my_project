using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.Assignment5_06
{
    class KrishnaMurthyNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter the number ");
            int n = int.Parse(Console.ReadLine());
            int x,sum=0,temp=n;
            while (n > 0)
            {
                x = n % 10;
                int fact = 1;
                while (x >0)
                {
                    fact = fact * x;
                    x--;
                }
                sum = sum + fact;
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine(" KrishnaMurthy Number"+temp);
            }
            else
            {
                Console.WriteLine(" Not a KrishnaMurthy Number "+temp);
            }
        }
    }
}
