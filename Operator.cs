using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class complex
    {
        public int a, b;

        public complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public static complex operator +(complex c1, complex c2)
        {
            complex c3 = new complex(c1.a + c2.a, c1.b + c2.b);
            return c3;
        }

        public static complex operator -(complex c1, complex c2)
        {
            complex c3 = new complex(c1.a - c2.a, c1.b - c2.b);
            return c3;
        }

        public static complex operator *(complex c1, complex c2)
        {
            complex c3 = new complex(c1.a * c2.a, c1.b * c2.b);
            return c3;
        }


        public override string ToString()
        {
            return a + "/" + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            complex c = new complex(5, 4);
            complex d = new complex(11, 5);
            complex w = c + d;
            complex f = c - d;
            complex k = c * d;
            Console.WriteLine(w);
            Console.WriteLine(f);
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
