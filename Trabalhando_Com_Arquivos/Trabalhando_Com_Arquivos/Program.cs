using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalhando_Com_Arquivos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\e5684672\OneDrive - FIS\Desktop\Para subir no github\Trabalhando_Com_Arquivos\NewTextDocument.txt";
            string targetPath = @"C:\Users\e5684672\OneDrive - FIS\Desktop\Para subir no github\Trabalhando_Com_Arquivos\NewTextDocument2.txt";

            try
            {

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);  
            }
        }
    }
}
