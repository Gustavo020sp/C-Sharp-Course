using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTeste.Entities
{
    public class Client
    {
        public string name { get; set; }
        public string email { get; set; }
        public DateTime birthDay { get; set; }  

        public Client()
        {

        }
        public Client(string name, string email, DateTime birthDay)
        {
            this.name = name;
            this.email = email;
            this.birthDay = birthDay;
        }
    }
}
