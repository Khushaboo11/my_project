using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.Oops_concept
{
    class Student
    {
        public long std_id;
        public string std_name;
        public int marks;
        public float result;

        void Input( long id,string name)
        {
            std_id = id;
            std_name = name;
           
        }
        void Percentage()
        {
            Console.WriteLine("enter the marks of subject one");
            int sub1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the marks of subject second");
            int sub2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the marks of subject third");
            int sub3 = int.Parse(Console.ReadLine());
           marks = sub1 + sub2 + sub3;
            result = marks / 3.0F;
        }
        void Display()
        {
            Console.WriteLine("student id ="+std_id);
            Console.WriteLine("student name ="+std_name);
            Console.WriteLine(" student marks ="+marks);
            Console.WriteLine(" percentage =" + result);
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Input(1723110048, "alina");
            s.Percentage();
            s.Display();
        }
    }
}
