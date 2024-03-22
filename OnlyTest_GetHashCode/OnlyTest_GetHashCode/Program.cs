using System;
using OnlyTest_GetHashCode.Entities;


namespace OnlyTest_GetHashCode
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string name;
            HashSet<NameRecord> listNames = new HashSet<NameRecord>();

            Console.Write("How many names to the list? ");
            int numberNames = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberNames; i++) 
            {
                name = Console.ReadLine();
                listNames.Add(new NameRecord { name = name });
            }

            Console.WriteLine("Total Names: " +  listNames.Count);
            Console.ReadLine();
        }
    }
}
