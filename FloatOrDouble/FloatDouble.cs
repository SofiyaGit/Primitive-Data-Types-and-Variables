using System;

//Problem 2. Float or Double?
namespace FloatOrDouble
{
    class FloatDouble
    {
        static void Main()
        {
                    
            double numberOne = 34.567839023;
            double numberTwo = 8923.1234857;
            float numberThree = 12.345f;
            float numberFour = 3456.091f;

            Console.WriteLine("The first two are double : {0} --> {1} ", numberOne, numberTwo);
            Console.WriteLine("The second two are float : {0} --> {1} ", numberThree, numberFour);
        }
    }
}
