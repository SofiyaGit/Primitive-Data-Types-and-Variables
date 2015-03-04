using System;

//Problem 13.* Comparing Floats
namespace ComparingFloats
{
    class Compare
    {
        static void Main()
        {

            double eps = 0.000001;

            Console.WriteLine("Enter a first number  0,0...: ");

            string firstNum = Console.ReadLine();

            //convert a string to double
            double dFirstNum = Double.Parse(firstNum);

            Console.WriteLine("Enter a second number 0,0...: ");

            string secondNum = Console.ReadLine();

            //convert a string to double
            double dSecondNum = Double.Parse(secondNum);


            // take only the postive numbers
            if ( Math.Abs(dFirstNum - dSecondNum) > eps)

            {
                Console.WriteLine("The result is {0} ", false);
            }
             
            else 
            {
                Console.WriteLine("The result is {0} ", true);
            }

        }

    }
}
