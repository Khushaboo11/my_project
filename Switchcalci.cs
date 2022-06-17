using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.conditional
{
    class Switchcalci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" enter + for addition" +
                "enter - for substraction \n enter * for multiplication \n enter / for division");
            char ch = char.Parse(Console.ReadLine());
            int num3;
            switch (ch)
            {
                case '+':
                    num3 = num1 + num2;
                    Console.WriteLine("adiition =" + num3);
                    break;
                case '-':
                    num3 = num1 - num2;
                    Console.WriteLine("substraction =" + num3);
                    break;
                case '*':
                    num3 = num1 * num2;
                    Console.WriteLine("multiplication =" + num3);
                    break;
                case '/':
                    num3 = num1 / num2;
                    Console.WriteLine("division =" + num3);
                    break;
                default:
                    Console.WriteLine("oops you enter the wrong operator");
                    break;
            }
        }
    }
}
