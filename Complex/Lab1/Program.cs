using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Complex
    {
        public int a, b;
        public Complex (int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
                int cnt = c1.b * c2.b;
                int sum = c2.b * c1.a + c1.b * c2.a;
                if (cnt > sum)
            {
                for (int i = sum; i > 2; i--)
                {
                    if (cnt % i == 0 && sum % i == 0)
                    {
                        cnt = cnt / i;
                        sum = sum / i;
                        break;
                    }
                }
            }
            else
            {

                for (int i = cnt; i > 2; i--)
                {
                    if (cnt % i == 0 && sum % i == 0)
                    {
                        cnt = cnt / i;
                        sum = sum / i;
                        break;
                    }
                }
            }

            Complex c3 = new Complex(sum, cnt);
                return c3;
            }
        public static Complex operator -(Complex c1, Complex c2)
        {
            int cnt = c1.b * c2.b;
            int sum = c2.b * c1.a - c1.b * c2.a;
            if (cnt > sum)
            {
                for (int i = sum; i > 2; i--)
                {
                    if (cnt % i == 0 && sum % i == 0)
                    {
                        cnt = cnt / i;
                        sum = sum / i;
                        break;
                    }
                }
            }
            else
            {

                for (int i = cnt; i > 2; i--)
                {
                    if (cnt % i == 0 && sum % i == 0)
                    {
                        cnt = cnt / i;
                        sum = sum / i;
                        break;
                    }
                }
            }

            Complex c3 = new Complex(sum, cnt);
            return c3;
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            int cnt = c1.b * c2.b;
            int sum = c1.a * c2.a;
            if (cnt > sum)
            {
                for (int i = sum; i > 2; i--)
                {
                    if (cnt % i == 0 && sum % i == 0)
                    {
                        cnt = cnt / i;
                        sum = sum / i;
                        break;
                    }
                }
            }
            else
            {
                for (int i = cnt; i > 2; i--)
                {
                    if (cnt % i == 0 && sum % i == 0)
                    {
                        cnt = cnt / i;
                        sum = sum / i;
                        break;
                    }
                }
            }

            Complex c3 = new Complex(sum, cnt);
            return c3;
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            int cnt = c1.b * c2.a;
            int sum = c1.a * c2.b;
            if (cnt > sum)
            {
                for (int i = sum; i > 2; i--)
                {
                    if (cnt % i == 0 && sum % i == 0)
                    {
                        cnt = cnt / i;
                        sum = sum / i;
                        break;
                    }
                }
            }
            else
            {
                for (int i = cnt; i > 2; i--)
                {
                    if (cnt % i == 0 && sum % i == 0)
                    {
                        cnt = cnt / i;
                        sum = sum / i;
                        break;
                    }
                }
            }
            Complex c3 = new Complex(sum, cnt);
            return c3;
        }
        public string F()
        {
            return a + "/" + b; 
        }        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex d = new Complex(1, 15);
            Complex k = new Complex(4, 15);
            Complex sum = d / k;
            Console.WriteLine(sum.F());
           
            Console.ReadKey();
        }
    }
}
