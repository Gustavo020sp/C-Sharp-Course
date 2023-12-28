using Metodos_Abstratos_2._0.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Abstratos_2._0
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<TaxPayers> taxPayers = new List<TaxPayers>();

            Console.Write("Enter the number of tax payers: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{(i+1)} data: ");
                Console.Write("Individual or company (i/c)? ");
                char type = Convert.ToChar(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = Convert.ToDouble(Console.ReadLine());

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = Convert.ToDouble(Console.ReadLine());
                    TaxPayers taxpayers = new PhysicalPerson(healthExpenditures, name, anualIncome);
                    taxPayers.Add(taxpayers);
                }
                else
                {
                    Console.Write("Number of Employees: ");
                    int numberOfEmployees = Convert.ToInt32(Console.ReadLine());
                    TaxPayers taxpayers = new Company(numberOfEmployees, name, anualIncome);
                    taxPayers.Add(taxpayers);
                }

            }

            Console.WriteLine("TAXES PAID: ");

            foreach(TaxPayers taxpayers in taxPayers)
            {
                Console.WriteLine(taxpayers.Data());
            }

            Console.WriteLine("");

            //calculando o total de todos
            double total = 0;
            foreach (TaxPayers taxpayers in taxPayers)
            {
                 total = total + taxpayers.CalculateTax();
            }

            Console.WriteLine($"TOTAL TAXES: $ { total}");


            Console.ReadLine();
        }
    }
}
