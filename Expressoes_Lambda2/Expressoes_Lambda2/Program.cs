using Expressoes_Lambda2.Entities;
using System.Globalization;

namespace Expressoes_Lambda2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Projects\C-Sharp-Course\Expressoes_Lambda2\employees.csv";
            List<Employee> listEmployee = new List<Employee>();
            string[] employeeList;


            using(StreamReader sr = new StreamReader(path))
            {
                while(!sr.EndOfStream)
                {
                    employeeList = sr.ReadLine().Split(",");
                    string name = employeeList[0];
                    string email = employeeList[1];
                    double salary = Double.Parse(employeeList[2], CultureInfo.InvariantCulture);
                    listEmployee.Add(new Employee(name, email, salary));
                }
            }

            //this will select in the list the email of people whose salary is greater than 2000.00
            Console.Write("Enter salary: ");
            double salaryInput = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Email of people whose salary is greater than 2000.00: ");

            //here will implement the query using lambda and linq
            var emails = listEmployee.Where(e => e.Salary > salaryInput);

            foreach(Employee employee in emails )
            {
                Console.WriteLine(employee.Email);
            }


            //falta arrumar código abaixo para imprimir certo
            Console.WriteLine("Sum of salary of people whose name starts with 'M': ");

            var sum = listEmployee.Select(p => p.Salary).DefaultIfEmpty(0.0).Sum();

            Console.WriteLine(sum.ToString());

            Console.ReadLine();

        }
    }
}
