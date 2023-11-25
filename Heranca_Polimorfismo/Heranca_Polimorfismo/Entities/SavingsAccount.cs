using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Polimorfismo.Entities
{
    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            balance += balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            this.balance -= amount;
        }
    }
}
