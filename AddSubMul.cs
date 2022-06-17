using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.DoWhileLooping
{
    class AddSubMul
    {
        static void Main(string[] args)
        {
            int ch;
            do
            {
                Console.WriteLine("1 Addition \n 2 substraction \n 3 multiplication\n 4 division");
                Console.WriteLine("enter your choice");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the first number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the second number");
                int num2 = int.Parse(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        Console.WriteLine("Addition = " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Substraction = " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("multipication = " + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("division = " + (num1 / num2));
                        break;
                }
                Console.WriteLine("do you want to continue");
                ch = char.Parse(Console.ReadLine());

            } while (ch == 'y' || ch == 'Y');
            
        }
    }
}
