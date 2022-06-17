using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.DoWhileLooping
{
    class Disarium
    {
        static void Main(string[] args)
        {
            // the number as 135=(1^1)+(3^2)+(5^3)=135
            Console.WriteLine("enter the number to check number is disarium or not");
            int num = int.Parse(Console.ReadLine());
            int x=num,c=0;
            double temp = 0, n;
            int i = 1;
            while (x > 0)
            {
                x = x / 10;
                c++;
            }
            x = num;
            double j = c;
            while (x > 0)
            {
                n = x % 10;
                temp = temp + Math.Pow(n , j);
                x = x / 10;
                j--;

            }
            Console.WriteLine("after performing disarium process the number is "+temp);
            if (temp == num)
            {
                Console.WriteLine(" number is disarium");
            }
            else
            {
                Console.WriteLine("not disarium");
            }

        }
    }
}
