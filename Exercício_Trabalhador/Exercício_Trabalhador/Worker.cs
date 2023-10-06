using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Trabalhador.Enumerators
{
    public class Worker
    {
        public string name { get; set; }
        public WorkerLevelcs level {get; set; }
        public double baseSalary { get; set; }
        public Department department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        //construtores 
        public Worker()
        {

        }
        public Worker(string name, WorkerLevelcs level, double baseSalary, Department department)
        {
            this.name = name;
            this.level = level;
            this.baseSalary = baseSalary;
            this.department = department;
        }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = baseSalary;
            foreach(HourContract contract in Contracts)
            {
                if (contract.date.Year == year && contract.date.Month == month)
                {
                    sum += contract.totalValue();
                }
            }
            return sum;
        }
    }
}
