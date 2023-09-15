using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercício_Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int j = 1;
            int id = 0;
            string name = "";
            double salary = 0;
            double perc = 0;

            Console.Write("How many employees will be registered? ");
            n = Convert.ToInt32(Console.ReadLine());

            List<Employee> list_employees = new List<Employee>(n);

            //Employee emp = new Employee { Id = id, Name = name, Salary = salary };

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("Employee #" + (i+1) + ":");
                Console.Write("ID: ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Salary: ");
                salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("-------------------------");

                list_employees.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int id2 = Convert.ToInt32(Console.ReadLine());

            Employee emp = list_employees.Find(x => x.Id == id2);
            if (emp != null)
            {
                Console.WriteLine("Enter the percentege: ");
                perc = Convert.ToDouble(Console.ReadLine());
                emp.IncreaseSalary(perc);
            }
            else
            {
                Console.WriteLine("This id does not exist!");  
            }

            Console.WriteLine("");

            Console.WriteLine("Updated list of employees: ");

            foreach (object obj in list_employees)
            {
                Console.WriteLine(obj.ToString());
            }


            Console.ReadLine();
        }
    }
}
