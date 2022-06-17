using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.Oops_concept
{
   
  // static class ClassDemo
   // {
      /* void ClassDemo()
        {
            // we cannot contain not static constructor in the static method
        }
        private ClassDemo()
        {
            // static class cannot contain private constructor
        }*/
   // }


    class Demo
    {
        public float x=12;
        public static float y=24;

        public void Addition( )
        {

            
            Console.WriteLine("Addition = "+(x+y));
        }

       public static void Division()
        {
            Demo.y = y;
            Demo s = new Demo();
            Console.WriteLine(" Division = "+s.x/y);
        }
        
    }
    class Demo2
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.Addition();
            Demo.Division();
            
        }
    }

}
