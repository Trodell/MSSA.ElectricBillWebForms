using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4ChallengeLab1
{
    internal class Customer
    {
        public static double NetCalculator(int x)
        {
            double num;
            double num1;
            if (x <= 199)
            {
                num = x * 1.20;
                if (num > 400)
                {
                    num = 0.15 * num;
                }
                return num;
            }
            if (x >= 200 && x <= 399)
            {
                num = x * 1.50;
                if (num > 400)
                {
                    num = 0.15 * num;
                }
                return num;
            }
            if (x >= 400 && x <= 599)
            {
                num = x * 1.80;
                if (num > 400)
                {
                    num = 0.15 * num;
                }
                return num;
            }
            if (x >= 600)
            {
                num = x * 2.00;
                if (num > 400)
                {
                    num1 = 0.15 * num;
                    num = num + num1;
                    return num;

                }
                else
                {
                    return num;
                }

            }
            else
                return 0;
        }
    }

}
