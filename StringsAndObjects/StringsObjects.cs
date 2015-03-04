using System;

//Problem 6. Strings and Objects
namespace StringsAndObjects
{
    class StringsObjects
    {
        static void Main()
        {
            string greeting = "Hello";

            string useTheWord = "World";

            object greetWorld = (greeting + " " + useTheWord);

            string getTheGreeting = greetWorld.ToString();

            Console.WriteLine(greetWorld);
        }
    }
}
