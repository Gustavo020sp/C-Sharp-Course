using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalhador_Contratos.Entitites.Enums;

namespace Trabalhador_Contratos.Entitites
{
    public class Trabalhador
    {
        public string name { get; set; }
        public WorkerLevel level { get; set; }
        public double baseSalary { get; set; }

        //public override string ToString()
        //{
        //    //return "Name:" + this.name + "Department: " + depName ToString(); 
        //}
    }
}
