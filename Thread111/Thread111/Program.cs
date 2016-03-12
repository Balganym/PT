using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread started");

            Thread t = new Thread(thread1);
            t.Name = "Thread 1";
            Thread tt = new Thread(thread2);
            tt.Name = "Thread 2";
            t.Start();
            t.Join();
            tt.Start();
            tt.Join();

            Console.WriteLine("Main thread finished");
            Console.ReadKey();
        }

        public static void thread1()
        {
            for (int i = 0; i<7; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name +" " + i);
                Thread.Sleep(500);
            }
           
        }

        public static void thread2()
        {
            for (int i = 1; i<11; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name +" " + i);
                Thread.Sleep(500);
            }
            
        }
    }
}
