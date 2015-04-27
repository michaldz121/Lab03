using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler15
{
    public class SumOfPowers
    {
        private int result;
        public int Result
        {
            get
            {
                return result;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public SumOfPowers()
        {
            result = 0;
        }

        /// <summary>
        /// Computes exponential values
        /// <params name="baseNumber">the base</params>
        /// <params name="exponent">the exponent</params>
        /// <returns>The value of the first argument raised to the power of the second argument<returns>
        /// </summary>
        public static int GetPower(int baseNumber, int exponent)
        {
            int multiplier = baseNumber;

            //small loop to make the nth power of the digit as this is faster than using the math.pow function
            for (int i = 1; i < exponent; i++)
            {
                baseNumber *= multiplier;
            }

            return baseNumber;
        }
    }
}
