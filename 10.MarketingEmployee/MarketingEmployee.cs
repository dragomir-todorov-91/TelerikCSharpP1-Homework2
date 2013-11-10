//A marketing firm wants to keep record of its employees. Each record would have 
//the following characteristics – first name, family name, age, gender (m or f),
//ID number, unique employee number (27560000 to 27569999). Declare the variables
//needed to keep the information for a single employee using appropriate data 
//types and descriptive names.

using System;

class MarketingEmployee
{
    static void Main()
    {
        string firstName = "Ivan";
        string familyName = "Ivanov";
        short age = 35;
        char employeeGender = 'm';
        int employeeID = 918273;
        uint uniqueEmployeeNumber = 27567890;
        Console.WriteLine("First name: {0}\nFamily name: {1}\nAge: {2}\nGender:{3}\nEmployee ID: {4}\nUnique emplyee number: {5}", firstName, familyName, age, employeeGender, employeeID ,uniqueEmployeeNumber);
    }
}