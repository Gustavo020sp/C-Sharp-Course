using Interfaces_Part2.Services;
using Interfaces_Part2.Entities;
using System;

namespace Interfaces_Part2.Services
{
     public class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentege = 0.02;
        private const double MonthlyInterest = 0.01;

        public PaypalService()
        {
        }

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentege;
        }
    }
}
