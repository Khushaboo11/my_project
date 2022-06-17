using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.Inheritance
{
    class Vehical
    {
        public virtual void run()
        {
            Console.WriteLine(" vehical is running....");
           
        }
    }
    class Car : Vehical
    {
        public override void run()
        {
            Console.WriteLine(" car is running....");
            base.run();
            
           
        }

    }
    class truck : Vehical
    {
        public override void run()
        {
            Console.WriteLine("truck is running....");
            base.run();
        }
    }
    class OverridingDemo
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.run();

           /* Vehical v = new Car();
            v.run();*/

            Vehical t = new truck();
            t.run();
        }
    }
}
