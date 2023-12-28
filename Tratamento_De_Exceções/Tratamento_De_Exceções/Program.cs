using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tratamento_De_Exceções.Entities;

namespace Tratamento_De_Exceções
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime checkin = DateTime.Now;
            DateTime checkout = DateTime.Now;

            try
            {
                Console.Write("Room number: ");
                int roomNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Check-In date (dd/MM/yyy): ");
                checkin = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyy): ");
                checkout = Convert.ToDateTime(Console.ReadLine());
                Reservation reservation = new Reservation(roomNumber, checkin, checkout);
                Console.Write(reservation.ToString());

                Console.WriteLine();

                Console.Write("Enter data to update the reservation");
                Console.Write("Check-In date (dd/MM/yyy): ");
                checkin = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyy): ");
                checkout = Convert.ToDateTime(Console.ReadLine());
                reservation.UpdateDates(checkin, checkout);
                Console.Write(reservation.ToString());
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please insert number room.");
                Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("Incorret data. ");
                Console.ReadLine();
            }
        }
    }
}
