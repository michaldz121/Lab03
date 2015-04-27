using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler15.Tests
{
    /// <summary>
    /// Tests for SumOfFifthPowers Class
    /// </summary>
    [TestClass]
    public class SumOfPowersTests
    {
        SumOfPowers sum = new SumOfPowers();

        /// <summary>
        /// Tests for GetPower method
        /// </summary>
        [TestMethod]
        public void GetPowerTest()
        {
            // Expected values
            int expectedValue5_8 = 390625;
            int expectedValue9_5 = 59049;
            int expectedValue7_5 = 16807;
            int expectedValue6_7 = 279936;
            int expectedValue4_9 = 262144;

            // Actual values
            int actualValue5_8 = SumOfPowers.GetPower(5, 8);
            int actualValue9_5 = SumOfPowers.GetPower(9, 5);
            int actualValue7_5 = SumOfPowers.GetPower(7, 5);
            int actualValue6_7 = SumOfPowers.GetPower(6, 7);
            int actualValue4_9 = SumOfPowers.GetPower(4, 9);


            // Asserts
            Assert.AreEqual(expectedValue5_8, actualValue5_8, "Error with base 5 and exponent 8");
            Assert.AreEqual(expectedValue9_5, actualValue9_5, "Error with base 9 and exponent 5");
            Assert.AreEqual(expectedValue7_5, actualValue7_5, "Error with base 7 and exponent 5");
            Assert.AreEqual(expectedValue6_7, actualValue6_7, "Error with base 6 and exponent 7");
            Assert.AreEqual(expectedValue4_9, actualValue4_9, "Error with base 4 and exponent 9");
        }


        /// <summary>
        /// Tests for SumOfDigitsPower method
        /// </summary>
        [TestMethod]
        public void SumOfDigitsPowerTest()
        {
            // Expected values
            int expectedValue1634_4 = 1634;
            int expectedValue8208_4 = 8208;
            int expectedValue9474_4 = 9474;
            int expectedValue13192_5 = 13192;
            int expectedValue92727_5 = 92727;
            int expectedValue194979_5 = 194979;

            // Actual values
            int actualValue1634_4 = SumOfPowers.SumOfDigitsPower(1634, 4);
            int actualValue8208_4 = SumOfPowers.SumOfDigitsPower(8208, 4);
            int actualValue9474_4 = SumOfPowers.SumOfDigitsPower(9474, 4);
            int actualValue13192_5 = SumOfPowers.SumOfDigitsPower(34564, 5);
            int actualValue92727_5 = SumOfPowers.SumOfDigitsPower(92727, 5);
            int actualValue194979_5 = SumOfPowers.SumOfDigitsPower(194979, 5);


            // Asserts
            Assert.AreEqual(expectedValue1634_4, actualValue1634_4, "Error with number 1634 and power 4");
            Assert.AreEqual(expectedValue8208_4, actualValue8208_4, "Error with number 8208 and power 4");
            Assert.AreEqual(expectedValue9474_4, actualValue9474_4, "Error with number 9474 and power 4");
            Assert.AreEqual(expectedValue13192_5, actualValue13192_5, "Error with number 34564 and power 5");
            Assert.AreEqual(expectedValue92727_5, actualValue92727_5, "Error with number 92727 and power 5");
            Assert.AreEqual(expectedValue194979_5, actualValue194979_5, "Error with number 194979 and power 5");
        }


        /// <summary>
        /// Tests for Compute method
        /// </summary>
        [TestMethod]
        public void ComputeTest()
        {
            // Expected values
            int expectedValue4 = 19316;
            int expectedValue5 = 443839;
            int expectedValue6 = 0;

            // Actual values
            int actualValue4 = sum.Compute(4);
            int actualValue5 = sum.Compute(5);
            int actualValue6 = sum.Compute(6);


            // Asserts
            Assert.AreEqual(expectedValue4, actualValue4, "Error with power 4");
            Assert.AreEqual(expectedValue5, actualValue5, "Error with power 5");
            Assert.AreEqual(expectedValue6, actualValue6, "Error with power 6");
        }
    }
}