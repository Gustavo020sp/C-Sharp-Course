using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracao_Composicao.Entities
{
    public class Client
    {
        public string name { get; set; }
        public string email { get; set; }
        public DateTime bday { get; set; }

        //construtores
        public Client()
        {

        }
        public Client(string name)
        {
            this.name = name;          
        }
        public Client(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
        public Client(string name, string email, DateTime bday) 
        {
            this.name = name;
            this.email = email;
            this.bday = bday;
        }
    }
}
