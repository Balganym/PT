using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class large
    {
        public long a;
        public large(long a)
        {
            this.a = a;
        }

        public static large operator +(large c1, large c2)
        {
            large c3 = new large(c1.a + c2.a);
            return c3;
        }

        public override string ToString()
        {
            return a + "" ;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            large d = new large(7777777777777777);
            large k = new large(5555555555555555);
            large f = k + d;
            Console.WriteLine(f);
            Console.ReadKey(); 


        }   
    }
}
