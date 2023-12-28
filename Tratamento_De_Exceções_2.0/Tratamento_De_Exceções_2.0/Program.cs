using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tratamento_De_Exceções_2._0.Entities;

namespace Tratamento_De_Exceções_2._0
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double amount;

            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = Convert.ToDouble(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawlimit = Convert.ToDouble(Console.ReadLine());

                //instanciando nova conta com dados inseridos pelo usuário
                Account account = new Account(number, holder, balance, withdrawlimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                amount = Convert.ToDouble((string)Console.ReadLine());
                account.Withdraw(amount);
                Console.WriteLine(account.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
