using System;

namespace Tratamento_De_Exceções.Entities
{
    public class Reservation
    {
        public int roomNumber { get; set; }
        public DateTime checkin { get; set; }
        public DateTime checkout { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new Exception("verifique...");
            }
            
            this.roomNumber = roomNumber;
            this.checkin = checkin;
            this.checkout = checkout;
        }
        public int Duration()
        {
            TimeSpan duration = checkout.Subtract(checkin);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new Exception("Erro na data. verifique");
            }
            this.checkin = checkin;
            this.checkout = checkout;
        }

        public override string ToString()
        {
            return $"Reservation: Room {roomNumber}, check-in: {checkin.ToString("dd/MM/yyyy")}, checkout: {checkout.ToString("dd/MM/yyyy")}, {Duration()} night(s).".ToString();
        }

    }
}
