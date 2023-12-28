using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Abstratos_2._0.Entities
{
    public abstract class TaxPayers
    {
        public string name { get; set; }
        public double anualIncome { get; set; }

        public TaxPayers() { }

        public TaxPayers(string name, double anualIncome)
        {
            this.name = name;
            this.anualIncome = anualIncome;
        }

        public abstract double CalculateTax();
        public virtual string Data() 
        { 
            return name + ": " + " $" + CalculateTax();
        }
    }
}
