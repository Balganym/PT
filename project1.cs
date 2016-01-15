using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
  
    class Program
    {

        static void Main(string[] args)
        {
             double a, b;
             string name;
             char ch;

             Console.WriteLine("Enter your name:");
             name = Console.ReadLine();
             Console.WriteLine("Hello {0}!", name);
             Console.WriteLine("Give me 2 numbers");
             a = Convert.ToDouble(Console.ReadLine());
             b = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Choose operation: + - / *");
             ch = Convert.ToChar(Console.ReadLine());

             if (ch == '+')
             {
                 Console.WriteLine("a + b = {0}", a + b);
             }

             if (ch == '-')
             {
                 Console.WriteLine("a - b = {0}", a - b);
             }

             if (ch == '*')
             {
                 Console.WriteLine("a * b = {0}", a * b);
             }

             if (ch == '/')
             {
                 Console.WriteLine("a / b = {0}", a / b);
             }
             Console.WriteLine("OK");

          
            Console.ReadKey(); 
        }
    }
        
}
