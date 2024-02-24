using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Trabalhando_Com_Arquivos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string sourcePath = @"C:\Github\C-Sharp-Course\Trabalhando_Com_Arquivos\NewTextDocument.txt";
            string targetPath = @"C:\Github\C-Sharp-Course\Trabalhando_Com_Arquivos\Summary.csv";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1]);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine(prod.name + "," + prod.Total().ToString());
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);  
            }
           
            Console.ReadLine();
        }
    }
}
