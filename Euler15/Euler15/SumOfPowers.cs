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

        /// <summary>
        /// Computes the sum of each digit power in number
        /// <params name="number">base number</params>
        /// <params name="digitCount">Count of digits in number</params>
        /// <returns>Sum of digit power</returns>
        /// <usecase>int s = SumOfDigitsPower(123, 3)</usecase>
        /// </summary>
        public static int SumOfDigitsPower(int number, int power)
        {
            int sumOfPowers = 0;

            while (number > 0)
            {
                // computes the remainder after dividing its first operand by its second
                int remainder = number % 10;
                number /= 10;

                remainder = GetPower(remainder, power);

                sumOfPowers += remainder;
            }

            return sumOfPowers;
        }

        /// <summary>
        /// Computes the sum of all the numbers that can be written as the sum of fifth powers of their digits
        /// <params name="power">power</params>
        /// <returns>Sum of numbers</returns>
        /// </summary>
        public int Compute(int power)
        {
            throw new NotImplementedException();
        }
    }
}
