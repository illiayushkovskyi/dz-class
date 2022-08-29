using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangle
    {
        double side1, side2;
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

      

        public double Perimeter()
        {
            return 2 * side1 + 2 * side2;
        }

        public double Area()
        {
            return side1 * side2;
        }

   
    }

        internal class Program
    {
        static void Main(string[] args)
        {
            double side1 = Convert.ToDouble(Console.ReadLine());
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rect = new Rectangle(side1, side2);
            Console.WriteLine(rect.Area());
            Console.WriteLine(rect.Perimeter());
            Console.ReadKey();
        }
    }
}
