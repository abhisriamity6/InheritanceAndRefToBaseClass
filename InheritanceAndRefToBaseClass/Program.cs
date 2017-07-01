using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndRefToBaseClass
{
    class TwoDShape
    {
        double F_height;
        double F_width;

        // Property Declaration 

        public double Height
        {
            get
            {
                return F_height;
            }
            set
            {
                F_height = value < 0 ? -value : value;
            }

        }
        public double Width
        {
            get
            {
                return F_width;
            }
            set
            {
                F_width = value < 0 ? -value : value;
            }

        }
        public TwoDShape()
        {
            Height = Width = 0;
        }

        public TwoDShape(double a, double b)
        {
            Height = a;
            Width = b;
        }
        public TwoDShape(double a)
        {
            Height = a;
            Width = a;
        }
        public TwoDShape(TwoDShape obj)
        {
            Height = obj.Height;
            Width = obj.Width;
        }

        public void ShowDim()
        {
            Console.WriteLine("Width and height are " +
            Width + " and " + Height);


        }

    }
    class Triangle : TwoDShape
        {
            string Style;
            // Constructure
            public Triangle() : base()
            {
                Style = "Point";

            }
        public Triangle(string Styleparm, double a, double b) : base(a,b)
        {
            Style = Styleparm;

        }
        public Triangle(double a) : base(a)
            {
                Style = "isosceles";

            }
            public Triangle(Triangle obj ) : base(obj)
            {
                Style = obj.Style;

            }
            public double Area()
            {
                return Width * Height / 2;
            }
            public void ShowStyle()
            {
                Console.WriteLine("Triangle is " + Style);
            }


        }
    class Shapes
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle("Right",8.00,12.00);

            //Displaying  info about T1
            Console.WriteLine("Info for t1: ");
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Area is " + t1.Area());

            // Making copy of t1
            Triangle t2 = new Triangle(t1);
            //Displaying  info about T2
            Console.WriteLine("Info for t2: ");
            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine("Area is " + t2.Area());
            Console.Read();

        }
    }
}
