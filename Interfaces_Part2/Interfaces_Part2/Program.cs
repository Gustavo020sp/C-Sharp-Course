using Interfaces_Part2.Entities;
using Interfaces_Part2.Services;
using System.Globalization;

namespace Interfaces_Part2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int contractnumber, installments;
            DateTime date;
            double contractvalue;

            Console.WriteLine("Enter contract data: ");
            Console.WriteLine("Number: ");
            contractnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Date (dd/MM/yyyy): ");
            date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Contract value: ");
            contractvalue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number of installments: ");
            installments = Convert.ToInt32(Console.ReadLine());

            List<string> number_installments = new List<string>();

            Contract mycontract = new Contract(contractnumber, date, contractvalue);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(mycontract, installments);

            Console.WriteLine("Installments:");
            foreach (Installment installment in mycontract.installment)
            {
                Console.WriteLine(installment);
            }

        }
    }
}