using System;

//Problem 12. Null Values Arithmetic
namespace NullValues
{
    class NullValue
    {
        static void Main()
        {
            int? intNum = null;

            Console.WriteLine("This is the integer with Null value -> " + intNum);

            intNum = 5;

            Console.WriteLine("This is the integer with value 5 -> " + intNum);

            double? doubleNum = null;

            Console.WriteLine("This is the integer with Null value -> " + doubleNum);

            doubleNum = 3.0596;

            Console.WriteLine( "This is the integer with value 5 -> " + doubleNum);

        }
    }
}
