using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Abstratos_2._0.Entities
{
    public class PhysicalPerson : TaxPayers
    {
        public double healthExpenditures { get; set; }

        public PhysicalPerson()
        {
        }
        public PhysicalPerson(double healthExpenditures, string name, double anualIncome) : base(name, anualIncome)
        {
            this.healthExpenditures = healthExpenditures;
        }

        public override double CalculateTax()
        {
            if (anualIncome < 20000)
            {
                return anualIncome * 15/100; //- healthExpenditures * (50 / 100);
            }
            else
            {
                return anualIncome * 25/100 - healthExpenditures * 50/100; //- healthExpenditures * (50 / 100);
            }
        }

        public override string Data()
        {
            return name + ": " + " $" + CalculateTax();
        }

    }
}
