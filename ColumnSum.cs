using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.ArrayExplaination
{
    class ColumnSum
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 4, 3 }, { 5, 7, 4 }, { 6, 8, 9 } };
            
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int sum = 0;
                for ( int j = 0; j < a.GetLength(1); j++)
                {
                    sum = sum + a[j,i];
                    Console.Write(a[j,i]+"  ");
                }
                Console.Write(" = "+sum);
                Console.WriteLine();
                    
                    
                    
                    
                    
            }  
        }
    }
}
