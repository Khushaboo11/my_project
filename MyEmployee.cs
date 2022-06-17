using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.Encapsulation
{
    class Mydate
    {
        private int dd;
        private int mm;
        private int yy;

        public int Dd
        {
            get { return dd; }
            set { dd = value; }
        }
        public int Mm
        {
            get { return mm; }
            set { mm = value; }
        }
        public int Yy
        {
            get { return dd; }
            set { dd = value; }
        }
    }
    class MyDepartment
    {
        private int did;
        private string dname;

        public int Did
        {
            get { return did; }
            set { did = value; }
        }
        public string Dname
        {
            set;
            get;
        }
        
    }
    class MyEmployee
    {
        private int id;
        private string name;
        MyDepartment dept;
        Mydate dt;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public MyDepartment Dept
        {
            get { return dept; }
            set { dept = value; }
        }
        public Mydate Dt
        {
            get { return dt; }
            set { dt = value; }
        }
        static void Main(string[] args)
        {
            MyEmployee e = new MyEmployee();
            e.Id = 200;
            e.Name = "Amit";
            e.Dept = new MyDepartment();
            e.Dept.Did = 1;
            e.Dept.Dname = "Sales";

            e.Dt = new Mydate();
            e.Dt.Dd = 2;
            e.Dt.Mm = 6;
            e.Dt.Yy = 2022;

            Console.WriteLine(e.Id+" "+e.Name+" "+e.Dept.Did+" "+e.Dept.Dname+" "+e.Dt.Dd+"/"+e.Dt.Mm+"/"+e.Dt.Yy);



        }

    }
}
