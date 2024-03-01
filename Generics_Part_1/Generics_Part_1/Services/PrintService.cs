using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Part_1.Services
{
    public class PrintService<T>
    {
        public string convertedlist;
        public int values;
        List<string> listvalues = new List<string>();

        public PrintService(int values)
        { 
            this.values = values;
        }

        public void addValue(int values)
        {
            

            for (int i = 0; i < values; i++)
            {
                listvalues.Add(Console.ReadLine());
            }

            convertedlist = string.Join(", ", listvalues.ToArray());
        }       
        public void print()
        {
            Console.WriteLine("[" + convertedlist + "]\n"
            + "First: " + listvalues.First());
        }
    }
}
