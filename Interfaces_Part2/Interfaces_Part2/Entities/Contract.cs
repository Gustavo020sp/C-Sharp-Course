namespace Interfaces_Part2.Entities
{
    public class Contract
    {
        public int contractnumber { get; set; }
        public double contractvalue { get; set; }   
        public DateTime date { get; set; }
        public List<Installment> installment { get; set; }

        public Contract(int contractnumber, DateTime date, double contractvalue)
        {
            this.contractnumber = contractnumber;
            this.date = date;
            this.contractvalue = contractvalue;
            installment = new List<Installment>();
        }

        public void AddInstallment(Installment installments)
        {
            installment.Add(installments);
        }

    }
}
