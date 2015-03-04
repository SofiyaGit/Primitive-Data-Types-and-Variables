using System;

//Problem 11. Bank Account Data
namespace BankAccount
{
    class Program
    {
        static void Main()
        {
            string firstName = "Ivan";
            string middleName = "Alexandrov";
            string lastName = "Ivanov";
            decimal balance = 100.56M;
            string bankName = "Unicredit";
            string IBAN = "BG15RSHH9";
            string[] creditCard = {"3456098712368736", "7890104834905682" ,"8901352090348907" };

            Console.WriteLine("Client's name : {0} {1} {2}", firstName, middleName, lastName);
            Console.WriteLine("Card balance : {0} in CreditCard : {1}", balance, creditCard[0]);
            Console.WriteLine("Name of bank : {0}", bankName);
            Console.WriteLine("IBAN : {0}", IBAN);
        }
    }
}
