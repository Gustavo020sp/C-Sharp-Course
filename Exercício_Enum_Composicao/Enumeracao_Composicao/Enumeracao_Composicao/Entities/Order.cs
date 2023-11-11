using Enumeracao_Composicao.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracao_Composicao.Entities
{
    public class Order
    {
        public DateTime moment = DateTime.Now;
        public OrderStatus status { get; set; }
        public Client client { get; set; }
        //public Order order { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item) 
        { 
            Items.Remove(item); 
        }
        //public double Total()
        //{

        //    //return this;
        //}

        //public override string ToString()
        //{
        //    return "ORDER SUMMARY: " +
        //    "Order moment: " + order.moment +
        //    "Order status: " + order.status +
        //    "Client: " + client.name + " " + client.bday + " - " + client.email.ToString();
        //}
    }
}
