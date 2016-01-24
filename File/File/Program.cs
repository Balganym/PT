using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File
{
    class Program
{
        public static void WalkDirectoryTree(DirectoryInfo d, int depth)
        {
            try {
                foreach (FileInfo file in d.GetFiles())
                {
                    Console.WriteLine("depth = {1}, File = {1}", depth, file.Name);
                }

                foreach (DirectoryInfo directory in d.GetDirectories())
                {
                    Console.WriteLine("depth = {0}, Directory = {1}", depth, directory.Name);
                    WalkDirectoryTree(directory, depth + 1);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
      }
    static void Main(string[] args)
    {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Useer\Desktop\Balganym");
            WalkDirectoryTree(d, 0);

            Console.ReadKey();
    }
}
}
