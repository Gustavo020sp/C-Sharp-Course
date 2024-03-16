using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste14032024.Services
{
    public class BrazilTaxServices
    {
        public double Tax(double ammount)
        {
            if (ammount <= 100)
            {
                return ammount * 0.2;               
            }
            else
            {
                return ammount * 0.15;
            }
        }
    }
}
