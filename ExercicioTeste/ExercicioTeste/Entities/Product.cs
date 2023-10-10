using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTeste.Entities
{
    public class Product
    {
        public string prodName { get; set; }
        public double prodPrice { get; set; }

        public Product()
        {
        }
        public Product(string prodName, double prodPrice)
        {
            this.prodName = prodName;
            this.prodPrice = prodPrice;
        }

    }
}
