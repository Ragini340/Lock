using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lock
{
   public class Process
    {
        static void Main()
        {
            Thread[] threads = new Thread[10];
            Department dep = new Department(1000);
            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(new ThreadStart(dep.DoTransactions));
                threads[i] = t;
            }
            for (int i = 0; i < 10; i++)
            {
                threads[i].Start();
            }
            Console.Read();
        }
    }
} 