using System;

//Problem 9. Exchange Variable Values
namespace ExchangeVariableValues
{
    class ExchangeValue
    {
        static void Main()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Value of a :{0} , value of b :{1}",a,b);

            if( a < b )
            {
                a += 5;
                b -= 5;

                Console.WriteLine("Value of a :{0} , value of b :{1}",a,b);
            }
        }
    }
}
