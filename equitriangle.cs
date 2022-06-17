using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.conditional
{
    class Equitriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the length of side");
            float side = float.Parse(Console.ReadLine());

             double root =  Math.Sqrt(3)*0.25;
            double area = root * side * side;
            Console.WriteLine("the area of equilateral triangle is "+area);
        }
    }
}
