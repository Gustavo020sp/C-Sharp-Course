using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Heranca_Polimorfismo.Entities
{
    public class usedProduct : Product
    {
        public DateTime manufactureDate { get; set; }

        public usedProduct()
        {
        }
        public usedProduct(DateTime manufactureDate, string name, double price) : base(name, price)
        {
            this.manufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return name + " (used) " + " $" + price + " (Manufacture date: " + manufactureDate + ")";
        }
    }
}
