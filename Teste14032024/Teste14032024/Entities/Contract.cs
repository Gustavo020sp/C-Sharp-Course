using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste14032024.Services;

namespace Teste14032024.Entities
{
    public class Contract
    {
        public string carModel { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public double priceHour { get; set; }
        public double priceDay { get; set; }
        public double Tax = 0;
        public double basicPayment = 0;
        public double totalPayment = 0;

        public Contract(string carModel, DateTime start, DateTime end, double priceHour, double priceDay)
        {
            this.carModel = carModel;
            this.start = start;
            this.end = end;
            this.priceHour = priceHour;
            this.priceDay = priceDay;
        }

        public void Calculate()
        {
            BrazilTaxServices _Brtaxservices = new BrazilTaxServices();
            TimeSpan duration = end - start;

            if (duration.Hours >= 12 || duration.Days >= 1)
            {               
                basicPayment = (Math.Ceiling(duration.TotalDays) * priceDay);
                //Tax = basicPayment * 0.15;
                Tax = _Brtaxservices.Tax(basicPayment);
                totalPayment = basicPayment + Tax;               
            }
            else
            {
                basicPayment = (Math.Ceiling(duration.TotalHours) * priceHour);
                //Tax = basicPayment * 0.2;
                Tax = _Brtaxservices.Tax(basicPayment);
                totalPayment = basicPayment + Tax;               
            }           
        }
        public override string ToString()
        {
            return "\nBasic payment: " + basicPayment 
                + "\nTax: " + Tax
                +"\nTotalPayment: " + totalPayment.ToString();
        }
    }
}
