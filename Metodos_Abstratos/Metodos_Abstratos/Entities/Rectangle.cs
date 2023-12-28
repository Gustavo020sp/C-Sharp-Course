using Metodos_Abstratos.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Abstratos.Entities
{
    public class Rectangle : Shape
    {
        public double width { get; set; }
        public double height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            this.width = width;
            this.height = height;
            //this.color = color;
        }

        public override double Area()
        {
            return width * height;
        }
    }
}
