using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additionaltask_lab2
{
    class Program
    {

        static void Main(string[] args)
        {
            string path = @"C:\Users\Useer\Desktop\Balganym";  
            DirectoryInfo d = new DirectoryInfo(path);

            int index = 0;
            List<FileSystemInfo> folders_files = new List<FileSystemInfo>(); 
            folders_files.AddRange(d.GetDirectories()); 
            folders_files.AddRange(d.GetFiles()); 

            bool files_folders = false; 
            while (true)
            {
                if (files_folders == false)
                {
                    for (int i = 0; i < folders_files.Count; i++)
                    {
                        if (index == i)
                        {
                            if (folders_files[i].GetType() == typeof(DirectoryInfo))
                            {
                                Console.BackgroundColor = ConsoleColor.Cyan;
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Cyan;
                                Console.ForegroundColor = ConsoleColor.DarkGray;

                            }
                        }
                        else
                        {
                            if (folders_files[i].GetType() == typeof(DirectoryInfo))
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                        }
                        Console.WriteLine(folders_files[i].Name);
                    }

                }
                ConsoleKeyInfo button = Console.ReadKey();
                if (button.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    if (index > 0)
                    {
                        index--;
                    }
                }
                if (button.Key == ConsoleKey.DownArrow)
                {
                   // Console.Clear();
                    if (index < folders_files.Count - 1)
                        index++;
                }
                if (button.Key == ConsoleKey.Enter)
                {
                    if (folders_files[index].GetType() == typeof(FileInfo))
                    {
                        Console.Clear();
                        FileStream f = new FileStream(folders_files[index].FullName, FileMode.OpenOrCreate, FileAccess.Read);
                        StreamReader sr = new StreamReader(f);
                        Console.Write(sr.ReadToEnd());
                        sr.Close();
                        f.Close();
                        files_folders = true;
                    }
                    else
                    {
                        Console.Clear();
                        path = folders_files[index].FullName;
                        d = new DirectoryInfo(path);
                        folders_files.Clear();
                        folders_files.AddRange(d.GetDirectories());
                        folders_files.AddRange(d.GetFiles());
                        index = 0;
                    }

                }
                if (button.Key == ConsoleKey.Escape)
                    if (folders_files[index].GetType() == typeof(FileInfo))
                    {
                        {
                            files_folders = false;
                            Console.Clear();
                        }
                    }

                    else
                    {
                        Console.Clear();
                         path = d.Parent.FullName;           //путь приравнивает к предыдущему путю                 
                         d = new DirectoryInfo(path);
                         folders_files.Clear();
                         folders_files.AddRange(d.GetDirectories());
                         folders_files.AddRange(d.GetFiles());
                         index = 0;                       
                    }
            }
        }
    }
}