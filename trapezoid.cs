using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    public class trapezoid
    {
      double base1, base2, height;

        public trapezoid(double b1, double b2, double h)
        {
            this.base1 = b1;
            this.base2 = b2;
            this.height = h;
        }

        public double area ()
        {
            return (base1 + base2) / 2 * height;
        }
    class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter base1, base2 and height of a trapezoid");
                double b1 = Double.Parse(Console.ReadLine());
                double b2 = Double.Parse(Console.ReadLine());
                double h = Double.Parse(Console.ReadLine());
                trapezoid area = new trapezoid(b1, b2, h);
                Console.WriteLine(area.area());
                Console.ReadKey();
            }
        }
    }
}
