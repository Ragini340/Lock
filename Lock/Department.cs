using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lock
{
    public class Department
    {
        private Object thisLock = new Object();
        int salary;
        Random r = new Random();
        public Department(int initial)
        {
            salary = initial;
        }
        int Withdraw(int amount)
        {
            if (salary < 0)
            {
                throw new Exception("Negative balance");
            }

            lock (thisLock)
            {
                if (salary >= amount)
                {
                    Console.WriteLine("Salary before withdrawal :  " + salary);
                    Console.WriteLine("Amount to withdraw        : -" + amount);
                    salary = salary - amount;
                    Console.WriteLine("Salary after withdrawal  :  " + salary);
                    return amount;
                }
                else
                {
                    return 0;
                }
            }
        }
        public void DoTransactions()
        {
            for (int i = 0; i < 100; i++)
            {
                Withdraw(r.Next(1, 100));
            }
        }
    }
}