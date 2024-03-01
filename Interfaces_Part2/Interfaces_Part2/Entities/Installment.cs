using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Part2.Entities
{
    public class Installment 
    {
        public DateTime dueDate { get; set; }
        public double Amount { get; set; }
        public Installment(DateTime dueDate, double amount)
        {
            this.dueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return dueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
