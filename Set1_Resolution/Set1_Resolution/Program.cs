using Set1_Resolution.Services;
using System.Security.Cryptography.X509Certificates;
using Set1_Resolution.Entities;

namespace Set1_Resolution
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //HashSet<LogRecord> set = new HashSet<LogRecord>();

            List<string> list = new List<string>();
            Console.WriteLine("Enter file full path: ");
            string path = Console.ReadLine();

            ReadFile file1 = new ReadFile(path);
            file1.GetTotalUsers();           
            Console.ReadLine();
        }
    }
}
