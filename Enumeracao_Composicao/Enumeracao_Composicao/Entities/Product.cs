using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracao_Composicao.Entities
{
    public class Product
    {
        public double subtotal;
        public string product_name { get; set; }
        public double product_price { get; set; }
        public int product_quantity { get; set; }
        

        //constructors
        public Product()
        {
        }
        public Product(string product_name)
        {
            this.product_name = product_name;
        }
        public Product(string product_name, double product_price) 
        {
            this.product_name = product_name;
            this.product_price = product_price;
        }
        public Product(string product_name, double product_price, int quantity)
        {
            this.product_name = product_name;
            this.product_price = product_price;
            this.product_quantity = quantity;
        }

        public void AddValue()
        {
           subtotal = product_price * product_quantity;
        }
        public override string ToString()
        {
            return product_name + ", $" + product_price + ", Quantity: " + product_quantity + ", subtotal: $" + subtotal.ToString();
        }
    }
}
