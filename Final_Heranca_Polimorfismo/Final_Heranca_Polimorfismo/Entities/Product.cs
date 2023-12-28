using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Heranca_Polimorfismo.Entities
{
    public class Product
    {
        public string name { get; set; }
        public double price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public virtual string priceTag()
        {
            return name + " $" + price .ToString();
        }
    }
}
