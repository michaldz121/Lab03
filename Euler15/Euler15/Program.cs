/*
	Euler Project 15
	
	AUTHOR:
		Paweł Gancarz, PK Mech, 13K3
	
	PROGRAMMING LANGUAGE:
		C#
	
	CONDING STANDARD:
		C# Coding Convention
*/

using System;

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