using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class largenumber
    {
        public long a;

        public largenumber( long a)
        {
            this.a = a;
        }

        public static largenumber operator +(largenumber c1, largenumber c2)
        {
            largenumber c3 = new largenumber(c1.a + c2.a);
            return c3;
        }

       public static largenumber operator -(largenumber c1, largenumber c2)
        {
            largenumber c3 = new largenumber(c1.a - c2.a);
            return c3;
        }

        public static largenumber operator *(largenumber c1, largenumber c2)
        {
            largenumber c3 = new largenumber(c1.a * c2.a);
            return c3;
        }

     
        public override string ToString()
        {
            return a + "";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            largenumber c = new largenumber(5555);
            largenumber d = new largenumber(1111);
            largenumber w = c + d;
            largenumber f = c - d;
            largenumber k = c * d;
            Console.WriteLine(w);
            Console.WriteLine(f);
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
