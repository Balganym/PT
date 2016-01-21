using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            FileInfo file = new FileInfo(@"C:\Users\Useer\Desktop\far2.0\lab #10.1 ");
            if (file.Exists)
            {
                Console.WriteLine("File name {0}, File fullname {1}", file.Name, file.FullName);
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadKey();
        }
    }
}
