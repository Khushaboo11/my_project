using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.basic_fundamentals
{
    class Area
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the values to calculate the area of circle");
            Console.WriteLine("enter the value of radius");
            float r = float.Parse(Console.ReadLine());
            float area = 3.14F * r * r;
            Console.WriteLine("area of circle"+area);

            
            Console.WriteLine("enter the values to calculate the area of triangle");
            Console.WriteLine(" enter the values of three sides of triangle");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float s=(a+b+c)*0.5F;
            double result = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("area of triangle"+result);

            Console.WriteLine("enter the values of length and breadth");
            float len = float.Parse(Console.ReadLine());

            float bth = float.Parse(Console.ReadLine());
            double cal = len * bth;
            Console.WriteLine(" area of rectangle "+cal);
        }
    }
}
