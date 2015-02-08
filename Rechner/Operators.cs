using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operators
    {
        public static Double Add(Double n1, Double n2)
        {
            return n1 + n2;
        }
        public static Double Sub(Double n1, Double n2)
        {
            return n1 - n2;
        }
        public static Double Mul(Double n1, Double n2)
        {
            return n1 * n2;
        }
        public static Double Div(Double n1, Double n2)
        {
            return n1 / n2;
        }
        public static Double Wur(Double n1, Double n2)
        {
            return Math.Pow(n1, (1/n2));
        }
        public static Double Zin(Double n1, Double n2, Double n3)
        {
            Double n4 = n2 / 100;
            return n1 * Math.Pow((1+n4), n3);
        }
    }
}
