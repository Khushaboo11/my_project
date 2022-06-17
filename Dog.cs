using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.Inheritance
{
    class Animal
    {
        protected int legs = 0;
        public Animal()
        {
            Console.WriteLine(" Animal");
        }

        public Animal(int x)
        {
            Console.WriteLine(" x ="+x);
        }
        public void foo()
        {
            Console.WriteLine(" parent");
        }
    }
    class Dog:Animal
    {
        int legs = 4;
        public Dog():base()
        {
            Console.WriteLine(" Dog ");
        }
        public Dog(int x):base(x)
        {
            Console.WriteLine(" My x child "+" "+x);
        }

        void show()
        {
            Console.WriteLine(legs+" "+base.legs);
            base.foo();
        }
        public void foo()
        {
            Console.WriteLine("child");
        }
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.show();
            d.foo();
            Dog d1 = new Dog(678);
        }

}   }
    

    

