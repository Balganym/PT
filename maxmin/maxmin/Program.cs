using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace maxmin
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream Naz1 = new FileStream(@"C:\Users\Useer\Desktop\Balganym\Nazymin.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream Naz2 = new FileStream(@"C:\Users\Useer\Desktop\Balganym\Nazymout.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            //StreamWriter sw1 = new StreamWriter(Naz1);// я написала эту строку,   
            //sw1.WriteLine(Console.ReadLine());        // чтобы отсюда считывать данные, но это не работает?
            StreamReader sr = new StreamReader(Naz1);
            StreamWriter sw = new StreamWriter(Naz2);

            string[] s = sr.ReadLine().Split();
              long min, max;              
              min = long.Parse(s[0]);
              max = long.Parse(s[0]);

              for (int i = 1; i < s.Length; i++  )
              {
                  long a = long.Parse(s[i]);  
                             
                      if (min >= a)
                      {
                         min = a;
                      }
                      if (max <= a)
                      {
                         max = a;
                      }
              }
              Console.WriteLine("min = {0}, max = {1}", min, max);
              

            sr.Close();
            sw.Close();
            Naz1.Close();
            Naz2.Close();
              Console.ReadKey(); 
        }
    }
}
