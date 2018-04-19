using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedMath4238
{
    public class Calculator
    {
        public int Factorial(int input)
        {
            if (input > 1)
            {
                return input * Factorial(input - 1);
            }
            else
            {
                return 1;
            }
        }
    }
}
