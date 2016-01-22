using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
  
    class Program
    {
        static void Main(string[] args)
        {

            string[] token = Console.ReadLine().Split(); // вводим числа через пробел, кака строка            
            for (int i = 0; i < token.Length; i++)
            {
                int cnt = 0; // задаем счетчик (который будет считать сколько делителей есть у данного числа)
                int a = int.Parse(token[i]); // каждый элемент строки запмсываем как тип integer             

                for (int j = 1; j <= a; j++) // пробегаемся по циклу от 1 до данного числа (то есть, делим данное число на все числа до самого числа)
                {
                    if (a % j == 0) // если данное число делится на кокое то число 
                    {
                        cnt++; // прибавляем нашеу счетчику 1
                    }
                }
                if (cnt < 3) // если счетчик, то есть число делителей меньше 3 (то есть делители 1 и само число)
                {
                    Console.Write("{0} ", a); // выводим это число (простое число)                    
                }
            }
            Console.ReadKey();
        }
    }
}
