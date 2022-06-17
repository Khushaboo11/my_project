using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.conditional
{
    class Days
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1 for manday \n enter 2 for tuesday \n enter 3 for wednesday \n " +
                "enter 4 thursday \n enter 5 friday \n enter 6 saturday \n enter 7 for sunday");
            int n = int.Parse(Console.ReadLine());
            switch(n)
            {
                case 1:
                    Console.WriteLine(" welcome today is monday....");
                    break;
                case 2:
                    Console.WriteLine(" welcome today is tuesday....");
                    break;
                case 3:
                    Console.WriteLine(" welcome today is wednesday....");
                    break;
                case 4:
                    Console.WriteLine(" welcome today is thursday....");
                    break;
                case 7:
                    Console.WriteLine(" welcome today is friday....");
                    break;
                case 5:
                    Console.WriteLine(" welcome today is saturday....");
                    break;
                case 6:
                    Console.WriteLine(" welcome today is sunday....");
                    break;
                default:
                    Console.WriteLine(" you enter a wrong day....");
                    break;
            }
        }
    }
}
