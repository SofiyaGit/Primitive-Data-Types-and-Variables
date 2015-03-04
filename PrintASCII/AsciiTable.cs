using System;
using System.Text;

//Problem 14.* Print the ASCII Table
namespace PrintASCII
{
    class AsciiTable
    {
        static void Main()
        {
            for (int i = 0; i <= 10; i++)
            {

              Console.WriteLine("{0:X} = {1}", i, (char)i);

            }
        }
    }
}
