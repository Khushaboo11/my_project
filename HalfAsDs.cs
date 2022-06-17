using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.ArrayExplaination
{
    class HalfAsDs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of element you enter the array");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("enter the elemewnt of the array");
            for (int i = 0; i < a.GetLength(0); i++)
            {

                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ",a));

            
            int temp;
            for(int i = 0; i < a.Length; i++)
            {
              
               for(int j = 0; j < a.Length; j++)
                {
                    if (j < a.Length / 2)
                    {
                        if (a[i] < a[j])
                        {
                            temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }
                    else
                    {
                         if (a[i] >a[j])
                            {
                                temp = a[i];
                                a[i] = a[j];
                                a[j] = temp;
                            }
                    }
                }
            }
            Console.WriteLine(string.Join(" ",a));
        }
    }
}
