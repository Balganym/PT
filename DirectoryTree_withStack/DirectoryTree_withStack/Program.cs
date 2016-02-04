using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryTree_withStack
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryTree(@"C:\Users\Useer\Desktop\Balganym");
        }
        static void DirectoryTree(string path)
        {
            Stack<string> st = new Stack<string>();// создаем стэк
            Console.WriteLine( path +":" + Directory.GetFiles(path).Length); // выводим количество файлов в начальной папке
            st.Push(path);// теперь, добавляем путь начальной папки в стэк

            while (st.Count > 0)// пробегаемся по циклу, пока стэк не станет пустым
            {
                
                string[] subDirs = Directory.GetDirectories(st.Pop());// в массив добавляем пути папок в текущей папке
                                                                      // то есть в папке который добавился в стэк самым последним                      
                    foreach (string s in subDirs) // пробегаемся по этим папкам
                {
                    Console.WriteLine(s + ": " + Directory.GetFiles(s).Length);//и выводим количество файлов в каждой папке

                    st.Push(s);//пути папок добавляем в стэк
                    Console.ReadKey(); // после того, как на экране выводится число файлов в папке
                                       // нажимаем на любую клавишу и смотрим след. папку
                }
            }
            

        }
    }
}