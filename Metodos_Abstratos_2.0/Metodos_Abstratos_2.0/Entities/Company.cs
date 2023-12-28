using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Abstratos_2._0.Entities
{
    public class Company : TaxPayers
    {
        public double numberOfEmployees { get; set; }

        public Company() { }
        public Company(double numberOfEmployees, string name, double anualIncome) : base(name, anualIncome) 
        {
            this.numberOfEmployees = numberOfEmployees;
        }

        public override double CalculateTax()
        {
            if (numberOfEmployees > 10) 
            {
                return anualIncome * 14 / 100;
            }
            else
            {
                return anualIncome * 16 / 100;
            }
        }

        public override string Data()
        {
            return name + ": " + " $" + CalculateTax();
        }
    }
}
