using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.Oops_concept
{
    // using this to refer the current instance member
    class UseOfThis
    {
        public string name;
        public string Name()
        {
            return name;
        }
        public void Setname(string name)
        {
            this.name = name;
        }
        static void Main(string[] args)
        {
            UseOfThis a = new UseOfThis();
            a.Setname(" Welcome ");
            Console.WriteLine(a.Name());
        }
    }


}
