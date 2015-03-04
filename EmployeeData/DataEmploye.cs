using System;

//Problem 10. Employee Data
namespace EmployeeData
{
    class DataEmploye
    {
        static void Main()
        {
            string firstName = "Ivan";
            string lastName = "Ivanov";
            byte age = 36;
            string[] gender = {"m" , "f" };
            long ID = 7901034058;
            uint uniqueEmployeeNum = 27650000;

            Console.WriteLine("First and Last name : {0} {1}",firstName,lastName);
            Console.WriteLine("Age :{0}", age);
            Console.WriteLine("Gender : {0}", gender[0]);
            Console.WriteLine("ID : {0}", ID);
            Console.WriteLine("Employee Number : {0}", uniqueEmployeeNum);
            
        }
    }
}
