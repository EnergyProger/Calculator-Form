using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Forms
{
    class Operations
    {
        public Operations() { }

        public double Sum(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Min(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Mul(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Del(double n1, double n2)
        {
            return n1 / n2;
        }

        public double Percent(double n1, double n2)
        {
            return n1 * n2 / 100;
        }

        public double Sqrt(double n)
        {
            return Math.Sqrt(n);
        }

        public double Pow(double n)
        {
            return Math.Pow(n,2);
        }

        public double OneDelNum(double n)
        {
            return 1 / n;
        }

        public double PlusMin(double n)
        {
            return -n;
        }
    }
}
