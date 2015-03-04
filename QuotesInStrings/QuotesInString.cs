using System;

//Problem 7. Quotes in Strings
namespace QuotesInStrings
{
    class QuotesInString
    {
        static void Main()
        {
            string withOutQuotation = "The \"use\" of quotations" + " " + "causes difficulties";

            Console.WriteLine("Without Quotation : {0}  ", withOutQuotation);

            string withQuotation = @"The ""use"" of quatations" + " " + "causes difficulties";

            Console.WriteLine("With Quotation : {0}  ", withQuotation);

            


        }

       
    }
}
