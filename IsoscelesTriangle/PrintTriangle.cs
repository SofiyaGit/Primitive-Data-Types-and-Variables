using System;
using System.Text;

//Problem 8. Isosceles Triangle
namespace IsoscelesTriangle
{
    class PrintTriangle
    {
        static void Main()
        {
            string symbol = "©";

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("   {0}    " ,symbol);
            Console.WriteLine("  {0} {1}  ",symbol, symbol);
            Console.WriteLine(" {0}   {1}  ",symbol,symbol);
            Console.WriteLine("{0} {1} {2} {3} ",symbol,symbol,symbol,symbol);


        }
    }
}
