using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment02
{

    class circle
    {
        private int _redious;

        public int Redious
        {
            get { return _redious; }
            set {
                


                _redious = value; 
            
            }
        }
    }
    public class Run
    {
        public static void RunTime()
        {
            Rectangle R = new Rectangle(10, 20);
            Console.WriteLine("  rectangle");
            Console.WriteLine("lenght- {0} breadth- {1}", R.length, R.breadth);
            Console.WriteLine("Perimeter- {0}", R.perimeter);
            Console.WriteLine("Area- {0}", R.Area());

            Square square = new Square(10);
            Console.WriteLine(" here is the area & perimeter of Square");
            Console.WriteLine("side {0}", square.side);
            Console.WriteLine("Perimeter- {0}", square.perimeter);
            Console.WriteLine("Area- {0}", square.Area());


        }
    }

    abstract class GeometricSymbols
    {
        abstract public decimal perimeter { get; }

        abstract public decimal Area();
    }
    class Triangle : GeometricSymbols
    {
        private int s1, s2, s3;

        public Triangle(int s1, int s2, int s3)
        {
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
        }
        public override decimal perimeter
        {
            get
            {
                return this.s1 + this.s2 + this.s3;
            }
        }
        public override decimal Area()
        {
            return 0.000000m;
        }
    }
    abstract class Quadrilateral : GeometricSymbols
    {
        protected int s1, s2, s3, s4;

        public override decimal perimeter
        {
            get
            {
                return this.s1 + this.s2 + this.s3 + this.s4;
            }
        }
        public abstract override decimal Area();
    }

    class Square : Quadrilateral
    {
        public Square(int side)
        {
            base.s1 = base.s2 = base.s3 = base.s4 = side;
        }
        public int side
        {
            get
            {
                return base.s1;
            }
        }
        public override decimal Area()
        {
            return base.s1 * base.s2;
        }

    }
    class Rectangle : Quadrilateral
    {
        public Rectangle(int length, int breadth)
        {
            base.s1 = base.s3 = length;
            base.s2 = base.s4 = breadth;
        }
        public int length
        {
            get
            {
                return base.s1;
            }
        }
        public int breadth
        {
            get
            {
                return base.s2;
            }
        }
        public override decimal Area()
        {
            return this.length * this.breadth;
        }
    }

}




