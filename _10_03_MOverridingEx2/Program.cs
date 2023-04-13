using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _10_03_MOverridingEx2
{
    class Shape {
        public virtual double getArea() {

            return 0;
        }
        public virtual double getCircumferace()
        {
            return 0;
        }
    }
    class Square : Shape {
        double length;
        public Square(double length)
        {
            this.length = length;
        }
        public override double getArea()
        {
            return length * length;
        }
        public override double getCircumferace()
        {
            return length * 4;
        }
    }

    class Rectangle : Shape {
        double width;
        double height;
        public Rectangle(double width, double height )
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
    }
     class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(50);
            Console.WriteLine("Area of Square is {0} ",s.getArea());
            Console.WriteLine("Circumference of Square is {0}", s.getCircumferace());

            Rectangle r = new Rectangle(50,25);
            Console.WriteLine("Area of rectangle is {0} ", r.getArea());
            Console.WriteLine("Circumference of Rectangle is {0}", r.getCircumferace());
        }
    }
}
