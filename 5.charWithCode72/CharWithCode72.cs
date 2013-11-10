//Declare a character variable and assign it with the symbol that has Unicode code 72.
//Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

using System;

class charWithCode72
{
    static void Main()
    {
        char char72;
        char72 = (char)0x48;
        Console.WriteLine(char72);
    }
}