using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculate
    {
        public string text { get; set; }
        public double sum, num1, num2;
        public string finalresult;

        public Calculate(string text)
        {
            this.text = text;
        }   

        public void DoCalculation(string text)
        {

            if (text.Contains('+'))
            {
                string firstnumber = text.Substring(text.LastIndexOf('+'));
                string secondnumber = text.Substring(0, text.IndexOf('+'));
                num2 = Convert.ToDouble(firstnumber.Substring(1));
                num1 = Convert.ToDouble(secondnumber);
                sum = num1 + num2;
                finalresult = Convert.ToString(sum);
                return;
            }
            if (text.Contains('x'))
            {
                string firstnumber = text.Substring(text.LastIndexOf('x'));
                string secondnumber = text.Substring(0, text.IndexOf('x'));
                num2 = Convert.ToDouble(firstnumber.Substring(1));
                num1 = Convert.ToDouble(secondnumber);
                sum = num1 * num2;
                finalresult = Convert.ToString(sum);
                return;
            }
            if (text.Contains('-'))
            {
                string firstnumber = text.Substring(text.LastIndexOf('-'));
                string secondnumber = text.Substring(0, text.IndexOf('-'));
                num2 = Convert.ToDouble(firstnumber.Substring(1));
                num1 = Convert.ToDouble(secondnumber);
                sum = num1 - num2;
                finalresult = Convert.ToString(sum);
                return;
            }
            if (text.Contains('/'))
            {
                string firstnumber = text.Substring(text.LastIndexOf('/'));
                string secondnumber = text.Substring(0, text.IndexOf('/'));
                num2 = Convert.ToDouble(firstnumber.Substring(1));
                num1 = Convert.ToDouble(secondnumber);
                sum = num1 / num2;
                finalresult = Convert.ToString(sum);
                return;
            }
        }
        public override string ToString()
        {
            return finalresult.ToString();
        }
    }
}
