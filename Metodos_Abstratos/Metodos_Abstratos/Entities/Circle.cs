using Metodos_Abstratos.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Abstratos.Entities
{
    public class Circle : Shape
    {
        public double radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return 3.14 * (radius * radius);
        }
    }
}
