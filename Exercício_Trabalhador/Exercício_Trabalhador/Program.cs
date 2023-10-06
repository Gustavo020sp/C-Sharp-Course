using Exercício_Trabalhador.Enumerators;
using System;

namespace Exercício_Trabalhador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameDept;
            string name;
            //string level;
            double baseSalary = 0;
            int contracts = 0;
            DateTime date;
            double valuePerHour;
            int hours;

            Console.Write("Enter department's name: ");
            nameDept = Console.ReadLine();
            Department department = new Department(nameDept);

            Console.WriteLine("WORKER DATA");
            Console.Write("Name: ");
            name = Console.ReadLine();  
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevelcs level = (WorkerLevelcs)Enum.Parse(typeof(WorkerLevelcs), (Console.ReadLine()));
            Console.Write("Base Salary: ");
            baseSalary = Convert.ToDouble(Console.ReadLine());
            Worker worker = new Worker(name, level, baseSalary, department);

            Console.Write("How many contracts to this worker? ");
            contracts = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < contracts; i++)
            {
                Console.WriteLine("Enter #" + (i+1) + " contract data: ");
                Console.Write("Date (DD/MM/YYY): ");
                date = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Value per hour: ");
                valuePerHour = Convert.ToDouble(Console.ReadLine());
                Console.Write("Duration (hours): ");
                hours = Convert.ToInt32(Console.ReadLine());
                HourContract hourcontract = new HourContract(date, valuePerHour, hours);
                worker.addContract(hourcontract);
            }
            Console.WriteLine("");

            Console.Write("Enter month and year to calculate income(MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3, 4));
            Console.Write("Name: " + worker.name);
            Console.Write("Department: " + department.nameDept);
            Console.WriteLine("Income for " + month + year + ": " + worker.Income(year, month));


            Console.ReadLine();
        }
    }
}
