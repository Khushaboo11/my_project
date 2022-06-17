using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.Inheritance
{
    class Printer
    {
        public virtual void show()
        {
            Console.WriteLine("show");
        }
    }
    class Laser : Printer
    {
         sealed public override void show()
        {
            Console.WriteLine(" Laser");
        }
    }
    class OfficeJet : Laser
    {
      /*  public override void show()  cannot ovveride  inherited member of sealed mthod
        {
            Console.WriteLine("my");
        }*/
    }
    class MyClass
    {
        static void Main(string[] args)
        {
            /*  laser l = new laser();
              l.show();*/
            OfficeJet f = new OfficeJet();
            f.show();

           /* Printer p = new Printer();
            p.show();*/
        }
    }
}
