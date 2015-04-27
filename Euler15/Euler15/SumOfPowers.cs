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
            throw new NotImplementedException();
        }
    }
}
