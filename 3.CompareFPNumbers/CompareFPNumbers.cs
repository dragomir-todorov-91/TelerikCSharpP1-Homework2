//Write a program that safely compares floating-point numbers with 
//precision of 0.000001. Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

using System;

//Write a program that safely compares floating-point numbers with precision 
//of 0.000001. Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

class CompareFPNumbers
{
    static void Main()
    {
        double number1, number2;
        
        Console.Write("Please enter the first number:");
        double.TryParse(Console.ReadLine(),out number1);
        Console.Write("Please enter the second number:");
        double.TryParse(Console.ReadLine(), out number2);

        if(Math.Abs(number1 - number2) < 1e-6)
            Console.WriteLine("Numbers are equal!");
        else
            Console.WriteLine("The numbers are not equal!");

    }
}