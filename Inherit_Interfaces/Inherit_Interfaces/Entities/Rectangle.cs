using Inherit_Interfaces.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit_Interfaces.Entities
{
    public class Rectangle : Shape
    {
        public double width {  get; set; }
        public double height { get; set; }
        //public Color color {  get; set; }

        public override double Area()
        {
            return width * height;
        }

        public override string ToString()
        {
            return "Area: " + Area() + ", Color: " + color + ", Width: " + width + ", Height: " + height.ToString();
        }
    }
}
