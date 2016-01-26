using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Lecture1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Useer\Desktop\far2.0\Balganym");
            int cnt = Search(d);
            Console.WriteLine(cnt);
            Console.ReadKey();
        }
        static int Search(DirectoryInfo d)
        {
            FileInfo[] files = d.GetFiles();
            int cnt_files = files.Length;

            DirectoryInfo[] directories = d.GetDirectories();
            foreach(DirectoryInfo  directory in directories){
                cnt_files += Search(directory);
            }
            return cnt_files;
        }
    }
}
