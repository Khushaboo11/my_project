using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.Oops_concept
{
    class Car
    {
       
        public void entery(string x,string y,string z,int i)
        {
            Console.WriteLine(" car model \n "+x+" car name \n"+y+" car color \n"+z+" car prize\n"+i);
        }
        
     
        
        static void Main(string[] args)
        {
            Car a = new Car();
            a.entery("dl00023456","maruti","black",6000000);
        }

    }
}
