using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.conditional
{
    class Vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any character");
            char ch = char.Parse(Console.ReadLine());
            if ((ch >= 'a' || ch <= 'z') || (ch >= 'A' || ch <= 'Z'))
            {
                Console.WriteLine("it is alphabet");
            }
            else if (ch <= '0' || ch >= '9')
            {
                Console.WriteLine("it is a digit");
            }
            else
            {
                Console.WriteLine("it is a special charchter");
            }

            /*if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u'||ch=='U')
            {
                Console.WriteLine("it is a vowel");
            }
            else
            {
                Console.WriteLine("it is a consonant");
            }*/

            switch (ch)
            {
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'i':
                case 'I':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    Console.WriteLine(" it is a vowel");
                    break;
                default:
                    Console.WriteLine("it is a consonant");
                    break;

            }
        }
    }
}
