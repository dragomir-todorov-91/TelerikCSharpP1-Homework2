//Create a program that assigns null values to an integer and to double variables.
//Try to print them on the console, try to add some values or the null literal to them and see the result.

using System;

class NullInIntAndDouble
{
    static void Main()
    {
        int? nullableInt;
        double? nullableDouble;

        nullableInt = 5;
        nullableInt += 9; // Has a value!
        nullableDouble = 5.635;
        Console.WriteLine("Set numbers: " + nullableInt + " | " + nullableDouble);

        nullableInt = null;
        nullableInt += 9; // Doesn't have a value!
        nullableDouble = null;
        Console.WriteLine("Set numbers in null: " + nullableInt + " | " + nullableDouble);
    }
}
