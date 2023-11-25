using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracao_Composicao.Entities
{
    public class Order
    {
        public double total_price { get; set; }

        public Order()
        {

        }
        public Order(double total_price)
        {
            this.total_price = total_price;
        }
    }
}
