using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler15
{
    class Program
    {
        public static void Main()
        {
            SumOfPowers euler = new SumOfPowers();

            Console.WriteLine(euler.Compute(5));
            Console.ReadKey();
        }
    }
}
