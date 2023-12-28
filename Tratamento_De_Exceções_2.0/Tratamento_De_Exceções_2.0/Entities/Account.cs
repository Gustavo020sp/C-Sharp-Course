using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tratamento_De_Exceções_2._0.Entities
{
    public class Account
    {
        public int number { get; set; }
        public string holder { get; set; }
        public double balance { get; set; }
        public double withdrawlimit { get; set; }
        //public double amount { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawlimit)
        {
            this.number = number;
            this.holder = holder;
            this.balance = balance;
            this.withdrawlimit = withdrawlimit;
        }

        public void Deposit(double amount)
        {
            balance = balance + amount;
        }

        public void Withdraw(double amount)
        {
            if (withdrawlimit < amount)
            {
                throw new Exception("Withdraw error: The amount exceeds withdraw limit! ");
            }
            if(withdrawlimit > balance)
            {
                throw new Exception("Withdraw error: Not enough balance!! ");
            }

            balance = balance - amount;
        }

        public override string ToString()
        {
            return $"New balance: $ {balance}".ToString();
        }
    }
}
