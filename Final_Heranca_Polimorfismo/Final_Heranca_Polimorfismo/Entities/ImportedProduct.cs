using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Heranca_Polimorfismo.Entities
{
    public class ImportedProduct : Product
    {
        public double customsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(double customsFee, string name, double price) : base(name, price)
        {
            this.customsFee = customsFee;
        }

        public double totalPrice()
        {
            return price + customsFee;
        }

        public override string priceTag()
        {
            return name + " $" + totalPrice() + " Customs fee $" + customsFee;
        }
    }
}
