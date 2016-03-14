using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_class
{
    class ThreadClass
    {
       
        public ThreadClass(int a)
        {

            Thread[] t = new Thread[a];
            for (int i = 0; i < a; i++)
            {
                t[i] = new Thread(f);
                t[i].Name = "my thread " + i;
                t[i].Start();
                t[i].Join();
                Thread.Sleep(500);               
            }
        }

        public void f()
        {
            for (int i = 1; i<6; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + i);
                Thread.Sleep(1000);
            }        
        }
    }
}
