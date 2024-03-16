using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace Exer_fixacao_Files_Directories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>();
            string sourcePath = @"C:\Gustavo\Products\productList.txt";
            string outputPath = @"C:\Gustavo\Products\Out\summary.csv";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                //a partir daqui ja tenho o vetor preenchido
                using (StreamWriter sw = new StreamWriter(outputPath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Products prod = new Products(name, price, quantity);
                        sw.WriteLine(prod.name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    } 
                }                       
            }
            catch(Exception e)
            {
                Console.WriteLine("ERRO: \n" + e.Message);
            }
        }
    }
}