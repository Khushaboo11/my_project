using System;
using System.Collections.Generic;
using System.Text;

namespace microsoft_batch.Encapsulation
{
    class PenNib
    {
        string materialtype;
        public PenNib(string materialtype)
        {
            this.materialtype = materialtype;
           
        }
        public void displaytype()
        {
            Console.WriteLine(materialtype);
            
        }
    }
    class Pen
    {
        int len;
        string pencol;
        int price;
        PenNib nib;
        public Pen(int len, string pencol, int price, PenNib nib)
        {
            this.len = len;
            this.pencol = pencol;
            this.price = price;
            this.nib = nib;

        }
         public void DisplayPen()
        {
            Console.WriteLine(len+" "+pencol+" "+price);
            nib.displaytype();
        }
    }
    class Bag
    {
        string brand;
        string color;
        Pen pen;
        public Bag(string brand,string color,Pen pen)
        {
            this.brand = brand;
            this.color = color;
            this.pen = pen;
        }
       void Show()
        {
            Console.WriteLine(brand+" "+color);
            pen.DisplayPen();
        }
        static void Main(string[] args)
        {
            Bag b = new Bag("American tourister", "Blue", new Pen(4, "white",123455 ,new PenNib("silk cotton")));
            b.Show();
        }


    }
}
