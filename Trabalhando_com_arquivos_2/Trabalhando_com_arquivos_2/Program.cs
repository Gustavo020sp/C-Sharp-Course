using System.IO;
using System.Collections.Generic;
namespace Trabalhando_com_arquivos_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> mylist = new List<string>();
            string path = @"C:\Gustavo\myfolder";
            //string sourcepath = @"C:\Gustavo\file1.txt";
            //string outputPath = @"C:\Gustavo\file2.txt";
            //FileStream fs = null;
            //StreamReader sr = null;

            try
            {
                //---------------------TRABALHANDO COM FILE E FILEINFO--------------------\\
                //FileInfo fileInfo = new FileInfo(sourcepath);
                //fileInfo.CopyTo(outputPath);
                //string[] lines = File.ReadAllLines(sourcepath);

                //foreach(string line in lines)
                //{
                //    Console.WriteLine(line);
                //}
                //--------------------------------------------------------------------------\\




                //************************************************************************************************************************\\
                //************************************************************************************************************************\\




                //--------------------USANDO FILESTREAM E STREAMREADER-----------------------\\
                //fs = new FileStream(sourcepath, FileMode.Open); 
                //sr = new StreamReader(fs);

                //while (!sr.EndOfStream)
                //{
                //    string line = sr.ReadLine();    
                //    Console.WriteLine(line);
                //}
                //-----------------------------------------------------------------------------\\




                //************************************************************************************************************************\\
                //************************************************************************************************************************\\




                // >> MELHOR MÉTODO <<//-----------------------TRABALHANDO COM BLOCO USING----------------------------\\ >>MELHOR MÉTODO<<
                //using (FileStream fs = new FileStream(sourcepath, FileMode.Open))
                //{
                //    //Leitura de arquivo
                //    using(StreamReader sr = new StreamReader(fs))
                //    {
                //        while (!sr.EndOfStream)
                //        {
                //            string line = sr.ReadLine();
                //            mylist.Add(line);                           
                //        }
                //    }

                //    using(StreamWriter sw = new StreamWriter(outputPath))
                //    {
                //       foreach(string line in mylist)
                //        {
                //            sw.WriteLine(line.ToUpper());
                //        }
                //    }

                //}
                //-----------------------------------------------------------------------------\\

                //************************************************************************************************************************\\
                //************************************************************************************************************************\\


                //TRABALHANDO COM PASTAS DIRECTORY E DIRECOTYINFO\\
                //listando as subpastas a partir de uma pasta
                var folder =  Directory.EnumerateDirectories(path, "*.*",SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach (string folders in folder)
                {
                    Console.WriteLine(folders);
                }

                //listando arquivos a partir de uma pasta
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                //criando uma nova pasta
                //Directory.CreateDirectory(path + @"\newfolder");

            }
            catch (IOException e)
            {
                Console.WriteLine("Error: \n" + e.ToString());
            }

            //BLOCO FINALLY SÓ USA PRA FECHAR O STREAMREADER E FILESTREAM SE NÃO USAR O BLOCO USING
            finally
            {
                //if(sr != null && fs != null)
                //{
                //    sr.Close();
                //    fs.Close();
                //}               
            }

            
        }
    }
}