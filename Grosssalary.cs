using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.looping
{
    class Grosssalary
    {


        static void Main(string[] args)
        {

            Console.WriteLine("enter the bassic selery to calculate gross selery");
            float ab = float.Parse(Console.ReadLine());
            float hra, da, gross;

            if (ab <= 10000)
            {
                da = ab * (80.0F / 100);
                hra = (ab * (20.0F / 100));

            }
            else if (ab <= 20000)
            {
                da = ab * (90.0F / 100);
                hra = ab * (25.0F / 100);

            }
            else
            {

                da = ab * (95.0F / 100);
                hra = ab * (30.0F / 100);

            }
            gross = hra + da;
            Console.WriteLine("Gross salary = "+gross);
        }
    }
}
