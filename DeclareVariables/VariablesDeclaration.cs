using System;

//Problem 1. Declare Variables
namespace DeclareVariables
{
    class VariablesDeclaration
    {
        static void Main()
        {
            byte numberOne = 97;
            sbyte numberTwo = -117;
            ushort numberThree = 52130;
            short numberFour = -10000;
            int numberFive = 4825932;

            Console.WriteLine("{0} {1} {2} {3} {4}", numberOne, numberTwo, numberThree, numberFour, numberFive);
        }
    }
}
