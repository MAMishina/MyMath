using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class MathClass
    {
        public string SumAB (int a, int b)
        {
            try
            {
                int sum = 0;
                if (a > b)
                {
                    return "a должно быть меньше b";
                }
                else
                {
                    for (int i = a; i <= b; i++)
                    {
                        sum += i;
                    }
                    return sum.ToString();
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
