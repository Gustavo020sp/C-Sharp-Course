using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nRooms;
            string name;
            string email;
            int room = 0;

            Rent[] vect = new Rent[10];

            Console.Write("How many rooms will be rented? ");
            nRooms = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nRooms; i++)
            {
                Console.WriteLine("Rent #" + (i+1));
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Room: ");
                room = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                vect[room] = new Rent();
                vect[room].Name = name;
                vect[room].Email = email;
                vect[room].Room = room;    
            }

            Console.WriteLine("Busy rooms: ");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ":" + vect[i].Name + ", " + vect[i].Email);
                }
            }

            Console.Read();
        }
    }
}
