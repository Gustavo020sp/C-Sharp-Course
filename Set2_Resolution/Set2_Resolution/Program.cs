using Set2_Resolution.Entities;
using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Set2_Resolution
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n_students;
            int idStudent;

            //List<int> id = new List<int>();
            //para comparar se tem igual(ATÉ pra tirar duplicados), ao invés de LISTA, usar HASHSET !!!! // e Implementar GetHashCode,e Equals 
            //os dois override, para dar certo, conforme as regras na classe StudentRecord!!!! //

            HashSet<StudentRecord> id = new HashSet<StudentRecord>();

            Console.Write("How many students for course A? ");
            n_students = int.Parse(Console.ReadLine());

            for (int i = 0; i < n_students; i++)
            {
                idStudent = int.Parse(Console.ReadLine());
                id.Add(new StudentRecord { Id = idStudent }); ; 
            }

            Console.Write("How many students for course B? ");
            n_students = int.Parse(Console.ReadLine());

            for (int i = 0; i < n_students; i++)
            {
                idStudent = int.Parse(Console.ReadLine());
                id.Add(new StudentRecord { Id = idStudent }); ;
            }

            Console.Write("How many students for course C? ");
            n_students = int.Parse(Console.ReadLine());

            for (int i = 0; i < n_students; i++)
            {
                idStudent = int.Parse(Console.ReadLine());
                id.Add(new StudentRecord { Id = idStudent }); ;
            }

            Console.WriteLine("Total students: " + id.Count);

            Console.ReadLine();
        }        
    }
}

