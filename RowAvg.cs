using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.ArrayExplaination
{
    class RowAvg
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            Console.WriteLine("enter the elemewnt of the array");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());

                }
            }
            
                for (int i = 0; i < a.GetLength(0); i++)
            {
                
                float sum = 0.0f;
                float count = 0.0F;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum = sum + a[i,j];
                    Console.Write(a[i,j] + "  ");
                    count++;
                }
                float avg = sum / count;
                Console.Write(" = " + avg);
                Console.WriteLine();

            }
        }
    }
}
