using Heranca_Polimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exemplo abaixo - polimorfismo
            Account acc1 = new Account(0293, "Gustavo", 500);
            Account acc2 = new SavingsAccount(2342, "Anna", 500, 0.01);

            //virtual
            acc1.Withdraw(10);

            //override
            acc2.Withdraw(10);

            Console.WriteLine(acc1.balance);
            Console.WriteLine(acc2.balance);
            Console.ReadLine();
        }
    }
}
