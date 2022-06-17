using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.DoWhileLooping
{
    class Pattern
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class Star
    {
        //*
        //**
        //***
        //****
        //*****
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                    Console.Write(j);
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    class Tri
    {
        //*****
        //****
        //***
        //**
        //*
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for(int j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
    class TriNum
    {
        //54321
        //5432
        //543
        //54
        //5
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
        }
    }
    class One
    {
        //
        static void Main(string[] args)
        {
            for (int i=5;i>=1;i--)
            {
                for (int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    class Two
    {
        //1
        //23
        //456
        //78910
        //1112131415
        static void Main(string[] args)
        {
            int c = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(c);
                    c++;
                }
                Console.WriteLine();
            }
        }
    }
    class Three
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if(i==1||j==1||j==5||i==5)
                    Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
    class Four
    {
        static void Main(string[] args)
        {
            //1
            //10
            //101
            //1010
            //10101
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                  if(j%2==0)
                        Console.Write("0");
                  else
                        Console.Write("1");
                    
                }
                Console.WriteLine();
            }
        }
    }

}
