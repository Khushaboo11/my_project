using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.AbstractTest
{
    //we cannot creat the object of abstract class
    //we can create constructor in abstract class
    //we can use any type of access modiefier in abstract class
    //abstract class abstract method have only declaration not body
    //drive class is used to implement abstarct constructor
    //through the base keyword we are calling the  parent constructr
    //within theinterface only static variable  or satic method or internal method we can declare
    //interface can create constructor
    //interface have by default public abstract
    //interface contain only abstract method and abstract class all type of variable
    //where as interface diclare only static type of variable;
    //we cna able the declare the class where as constructor not allow interface;
    //by using abstract class not posiible to achieve multiple inheritane where as using interface 
    //we can able to acheive multiple inheritance;;

    //  ques-1.create one interface which contain one var is of int type ,create an abstract class which also contain int type of var
    //...create a child class to  perform addition of interface var and abstract class variable  and display;

    abstract class Animal
    {
        public abstract void show();//abstract method

        public void Myanmal()//non abstract class and conceret class
        {
            Console.WriteLine("my animal...");
        }
    }
    class Dog : Animal
    {
        public override void show()
        {
            Console.WriteLine("Dog.....");
        }
    }
    class AbstractDemo
    {
        static void Main(string[] args)
        {
            Animal a = new Dog();
            a.show();
            a.Myanmal();
        }
    }
}
