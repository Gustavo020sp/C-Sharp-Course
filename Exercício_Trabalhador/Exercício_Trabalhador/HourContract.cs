using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Trabalhador
{
    public class HourContract
    {
        public DateTime date { get; set; }
        public double valuePerHour { get; set; }
        public int hours { get; set; }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            this.date = date;
            this.valuePerHour = valuePerHour;
            this.hours = hours;
        }

        public double totalValue()
        {
            return this.valuePerHour * this.hours;
        }
    }
}
