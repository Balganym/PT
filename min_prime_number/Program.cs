using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace min_prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Useer\Desktop\Balganym\input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fs1 = new FileStream(@"C:\Users\Useer\Desktop\Balganym\output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(fs1);

            string[] s = sr.ReadLine().Split();
            int a;
            List<int> primes = new List<int>(); 

            for (int i = 0; i < s.Length; i++)
            {
                a = int.Parse(s[i]);
                int cnt = 0;

                for (int j = 1; j <= a; j++) {
                    if (a % j == 0) {
                        cnt++;
                    }                    
                }
                if (cnt < 3) {
                    primes.Add(a);                    
                }            
            }
            /*  //можно найти мин пробегаясь по циклу 
            int min = primes[0];
            foreach (int f in primes) {
                if (f < min) {
                    min = f;
                }
            }*/
            sw.WriteLine("Min prime number = {0}",primes.Min()); // или же можно найти минимум так 
                                                                 
            //sw.WriteLine("Min prime number = {0}", min);
            //Console.WriteLine("Min prime number = {0}", min);
            sr.Close();
            sw.Close();
            fs1.Close();
            fs.Close();

            Console.ReadKey();




        }
    }
}
