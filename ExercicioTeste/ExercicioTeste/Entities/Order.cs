using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTeste.Entities.Enums
{
    public class Order
    {
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }

        public OrderItem items { get; set; }

        public Order(OrderStatus status)
        {
            this.status = status;
        }
    }
}
