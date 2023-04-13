using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_04_MOBuiltin
{
    class Shape
    {   public virtual double getArea()
        {
            return 0;
        }
        public virtual double getCircumferace()
        {
            return 0;  }
        public override string ToString()
        {
            return "^-_ Shape _-^";  }
    }
    class Square : Shape
    {
        double length;
        public Square(double length)
        {
            this.length = length; }
        public override double getArea()
        {
            return length * length; }
        public override double getCircumferace()
        {
            return length * 4;}

        public override string ToString()
        {
             return "^-_ Square _-^";}
    }



    class Rectangle : Shape
    {
        double width;
        double height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double getArea()
        {
            return width * height;
        }
        public override double getCircumferace()
        {
            return (width + height) * 2;
        }

        public override string ToString()
        {
            return "^-_ Rectangle _-^";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            Square ss = new Square(15);
            Rectangle r = new Rectangle(10, 15);
            Console.WriteLine(s);
            Console.WriteLine(ss);
            Console.WriteLine(r);
        }
    }
}
