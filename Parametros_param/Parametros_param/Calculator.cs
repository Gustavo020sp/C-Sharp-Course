﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametros_param
{
    internal class Calculator
    {

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i<numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

    }
}
