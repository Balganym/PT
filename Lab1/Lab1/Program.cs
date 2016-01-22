using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Complex
    {
        public int a, b;   // создаем комплексное число (а/b)

        public Complex (int a, int b)   // создаем конструктор 
        {
            this.a = a; // указываем 
            this.b = b;
        }

        public static Complex operator +(Complex n1, Complex n2) // пишим оператор +, чтобы вне класса могли суммировать комплексные числа 
        {
            Complex sum = new Complex(n1.a + n2.a, n1.b + n2.b);
            return sum;
        }

        public override string ToString() // переопределяем нашу строку (пишим то,что нужно возвращать )
        {
            return a + "/" + b;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;  // создаю переменные
            num1 = Int32.Parse(Console.ReadLine()); 
            num2 = Int32.Parse(Console.ReadLine());
            num3 = Int32.Parse(Console.ReadLine());
            num4 = Int32.Parse(Console.ReadLine());

            Complex first_complex = new Complex(num1, num2); // обращаюсь к классу(передаю переменные)(здесь num1 = n1.a, num2 = n1.b и т.д.)
            Complex second_complex = new Complex(num1, num2);
            Complex sum = first_complex + second_complex; // вызываю оператор + 
        }
    }
}
