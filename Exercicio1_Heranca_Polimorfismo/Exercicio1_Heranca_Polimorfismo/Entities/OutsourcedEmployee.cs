using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Heranca_Polimorfismo.Entities
{
    public class OutsourcedEmployee : Employee
    {
        public double add_charge { get; set; }
        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, double hours, double valuePerHour, double add_charge) : base(name, hours, valuePerHour)
        {
            this.add_charge = add_charge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * add_charge;
        }
    }
}
