//Declare two string variables and assign them with following value:
//"The "use" of quotations causes difficulties."
//Do the above in two different ways: with and without using quoted strings.

using System;

class StringsWithQuotationMarks
{
    static void Main()
    {
        string str = "The \"use\" of quotations causes difficulties.";
        string quotedString = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("The string: " + str);
        Console.WriteLine("The quoted string: " + quotedString);
    }
}