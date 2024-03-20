using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inherit_Interfaces.Enums;

namespace Inherit_Interfaces
{
    public abstract class Shape
    {
        public Color color { get; set; }
        public abstract double Area();
        
    }
}
