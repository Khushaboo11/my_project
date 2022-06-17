using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.ArrayExplaination
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            char[] ch = { 'e', 'f', 't', 'k', 'm' };
            Console.WriteLine(string.Join(" ",ch));
            Console.WriteLine();
            int j = ch.Length - 1;
            for(int i = 0; i < ch.Length / 2; i++)
            {
                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
                j--;
            }

            Console.WriteLine();
            Console.WriteLine(string.Join(" ",ch));
            for (int i = 0; i < ch.Length ; i++)
            {
                Console.WriteLine(ch[i]);
            }
        }
    }
}
