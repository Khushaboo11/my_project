using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.Inheritance
{
    class Mobile
    {
        protected string memory = "128GB";
    }
    class Apple : Mobile
    {
       protected string camera = "3.5px";
        
      
    }
    class MyiPhonePro : Apple
    {
        string screen = "4.5 inches";
        void show()
        {
            Console.WriteLine(" Memory  " + memory + "  " +camera+" "+screen);
        }
        static void Main(string[] args)
        {
            MyiPhonePro a = new MyiPhonePro();
            a.show();
        }
    }
}
