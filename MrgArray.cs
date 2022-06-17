using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.ArrayExplaination
{
    class MrgArray
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 3, 3, 2, 2 };
            int[] a2 = { 7, 1, 9, 0, 11, 0, 1, 1 };
            Console.WriteLine(string.Join(" ",a1));
            Console.WriteLine();
            Console.WriteLine(string.Join(" ",a2));
            Console.WriteLine();
            int c = a1.Length + a2.Length;
            int[] a =new int[c];
            int d = 0;
            for (int i = 0; i < c; i++)
            {
                if (i < a1.Length)
                {
                    a[i] = a1[i];
                }
                else
                {
                    a[i] = a2[d];
                    d++;
                }
            }
            for (int i = 0; i < c; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();


          // this is to check occurance of array element
            for(int i = 0; i < a.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for(int k = i - 1; k >= 0;k-- )
                {
                    if (a[k] == a[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for(int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;

                        }
                    }

                    Console.WriteLine(a[i] + "  " + count);
                    // this is for unique occurance
                    /* if (count == 1)
                     {
                         Console.WriteLine(a[i]+"  "+count);
                     }*/
                    //this is for dubilcate occurance
                    /*if (count > 1)
                    {
                        Console.WriteLine(a[i]+"  "+count);
                    }*/
                }
                

            }
            Console.WriteLine("///////////////");
            Console.WriteLine("alternate");
            Console.WriteLine();
            int f = 0;
            int e = 0;
            int[] a3 = new int[c/2];
            int[] a4 = new int[c/2];
            for (int k = 0; k < c; k++)
            {
                if (k % 2 == 0)

                {
                    a3[f] = a[k];
                    f++;
                }
                else
                {
                    a4[e] = a[k];
                    e++;
                }
            }
            Console.WriteLine(string.Join("  ",a3));
            Console.WriteLine(string.Join("  ", a4));

        }

    }
}
