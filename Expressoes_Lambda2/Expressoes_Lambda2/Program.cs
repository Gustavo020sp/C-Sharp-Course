using Expressoes_Lambda2.Entities;
using System.Globalization;

namespace Expressoes_Lambda2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Projects\C-Sharp-Course\Expressoes_Lambda2\employees.csv";
            List<Employee> list = new List<Employee>();
            string[] employeeList;


            using(StreamReader sr = new StreamReader(path))
            {
                while(!sr.EndOfStream)
                {
                    employeeList = sr.ReadLine().Split(",");
                    string name = employeeList[0];
                    string email = employeeList[1];
                    double salary = Double.Parse(employeeList[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(name, email, salary));
                }
            }
        }
    }
}
