using Exercicio1_Heranca_Polimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Heranca_Polimorfismo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> list_employee = new List <Employee>();

            Console.Write("Number of employees: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #" + (i + 1) + " data: ");
                Console.Write("Outsourced (y/n)? ");
                string resp = Console.ReadLine();        

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                double hours = Convert.ToDouble(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = Convert.ToDouble((Console.ReadLine()));

                //criando empregador com os parametros e adicionando na lista
                if (resp == "Y" || resp == "y")
                {
                    Console.Write("Additional charge: ");
                    double add_charge = Convert.ToDouble(Console.ReadLine());
                    Employee outsourced = new OutsourcedEmployee(name, hours, valuePerHour, add_charge);
                    list_employee.Add(outsourced);
                }
                else
                {
                    Employee employee = new Employee(name, hours, valuePerHour);
                    list_employee.Add(employee);
                }

            }

            Console.WriteLine("PAYMENTS: ");

            foreach (Employee emp in list_employee)
            {
                Console.WriteLine(emp.ToString());
            }

            Console.Read();
          
        }
    }
}
