using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercicio1_Heranca_Polimorfismo.Entities
{
    public class Employee
    {
        public string name { get; set; }
        public double hours { get; set; }
        public double valuePerHour { get; set; }

        public Employee()
        {
        }
        public Employee(string name, double hours, double valuePerHour) 
        {
            this.name = name;
            this.hours = hours;
            this.valuePerHour = valuePerHour;
        }

        public virtual double Payment() 
        { 
            return hours * valuePerHour;
        }

        public override string ToString()
        {
            return name + " - " + "$" + valuePerHour.ToString();
        }
    }
}
