using Metodos_Abstratos.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Abstratos.Entities
{
    public abstract class Shape
    {
        public Color color { get; set; }


        public Shape(Color color)
        {
            this.color = color;
        }

        public abstract double Area();
        
    }
}
