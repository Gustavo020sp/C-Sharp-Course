using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inherit_Interfaces.Entities;

namespace Inherit_Interfaces.Entities
{
    public class Triangle : Shape
    {
        public double width {  get; set; }
        public double height { get; set; }

        public override double Area() { return (width * height) / 2; }

        public override string ToString()
        {
            return "Area: " + Area() + ",  Color: " + color + ",  Width: " + width + ",  Height: " + height.ToString();
        }
    }
}
