using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract public class shape
    {
        abstract public double perimeter {get;}
        abstract public double area { get; }
    }

    class circle : shape
    {
        public double radius;
        public override double area
        {
            get { return Math.PI * radius * radius; }
        }
        public override double perimeter
        {
            get
            {
                return Math.PI * 2 * radius;
            }
        }
    }

    class rectangle : shape
    {
        public double x;
        public double y;
        
        public double diagonal
        {
            get
            {
                return Math.Sqrt(x*x+y*y);
            }
            set
            {
                double ratio = value / diagonal;
                x = x*ratio;
                y = y*ratio;

            }
        }


        public override double perimeter
        {
            get
            {
                double p = 2 * x + 2 * y;
                return p;
            }
        }
        
        public override double area
        {
            get
            {
            double a = x*y;
            return a;
            }

        }

        public void stretch(double ratio)
        {
            y = y*ratio;
            x = x*ratio;
        }

        public rectangle()
        {
            x = 123;
            y = 11;
        }
    }

    public static class con
    {
        public static void display(shape sh)
        {
            Console.WriteLine("The perimeter is: " + Convert.ToString(sh.perimeter));
            Console.WriteLine("The area is: " + Convert.ToString(sh.area));
        }
    }
    class Program
    {
        static void Main()
        {
            
            
            rectangle r1 = new rectangle();
            r1.x = 3;
            r1.y = 4;

            circle c1 = new circle();
            c1.radius = 1;
            con.display(r1);
            con.display(c1);

            Console.ReadLine();
            
            /*
            Console.WriteLine("Enter length: ");
            string s = Console.ReadLine();
            r1.x = Convert.ToDouble(s);

            Console.WriteLine("Enter width: ");
            s = Console.ReadLine();
            r1.y = Convert.ToDouble(s);

            Console.WriteLine("The perimeter is: " + Convert.ToString(r1.perimeter));
            Console.WriteLine("The area is: " + Convert.ToString(r1.area));
            Console.WriteLine("The diagonal is: " + Convert.ToString(r1.diagonal));


            Console.WriteLine("Enter your new diagonal");
            s = Console.ReadLine();
            r1.diagonal = Convert.ToDouble(s);

            Console.WriteLine("The new x is: " + Convert.ToString(r1.x));
            Console.WriteLine("The new y is: " + Convert.ToString(r1.y));

            Console.WriteLine("The perimeter is: " + Convert.ToString(r1.perimeter));
            Console.WriteLine("The area is: " + Convert.ToString(r1.area));
            Console.WriteLine("The diagonal is: " + Convert.ToString(r1.diagonal));


            Console.WriteLine("Enter your stretch ratio");
            s = Console.ReadLine();
            double r = Convert.ToDouble(s);

            r1.stretch(r);

            Console.WriteLine("The new x is: " + Convert.ToString(r1.x));
            Console.WriteLine("The new y is: " + Convert.ToString(r1.y));

            Console.WriteLine("The perimeter is: " + Convert.ToString(r1.perimeter));
            Console.WriteLine("The area is: " + Convert.ToString(r1.area));
            Console.WriteLine("The diagonal is: " + Convert.ToString(r1.diagonal));

            Console.ReadLine();

            */

        }
    }
}
