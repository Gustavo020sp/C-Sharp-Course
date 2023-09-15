using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Lista
{
    public class Employee
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void IncreaseSalary(double perc)
        {
            Salary += Salary * perc / 100;
        }

        public override string ToString()
        {
                return Id + ", " + Name + ", " + "R$" + Salary;
        }

    }
}
