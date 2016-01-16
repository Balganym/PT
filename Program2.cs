using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @operator
{
    class largenumber
    {
        public long a;

        public largenumber(long a)
        {
            this.a = a;
        }

        public static largenumber operator +(largenumber c1, largenumber c2)
        {
            largenumber c3 = new largenumber(c1.a + c2.a);
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
            largenumber d = new largenumber(long.Parse(Console.ReadLine()));
            largenumber k = new largenumber(long.Parse(Console.ReadLine()));
            largenumber w = k + d;
            Console.WriteLine(w);
            Console.ReadKey();
        }
    }
}
