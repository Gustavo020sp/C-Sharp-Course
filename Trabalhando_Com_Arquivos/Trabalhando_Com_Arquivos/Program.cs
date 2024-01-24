using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalhando_Com_Arquivos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string sourcePath = @"C:\Github\C-Sharp-Course\Trabalhando_Com_Arquivos\NewTextDocument.txt";
            string outputPath = @"C:\Github\C-Sharp-Course\Trabalhando_Com_Arquivos\NewTextDocument2.txt";

            FileInfo fileInfo = new FileInfo(sourcePath);

            string[] files = File.ReadAllLines(sourcePath);

            try
            {
                //list.Add(sourcePath.ToLower);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);  
            }
        }
    }
}
