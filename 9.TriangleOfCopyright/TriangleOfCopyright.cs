//Write a program that prints an isosceles triangle of 9 copyright symbols ©.
//Use Windows Character Map to find the Unicode code of the © symbol. 
//Note: the © symbol may be displayed incorrectly.

using System;

class TriangleOfCopyright
{
    static void Main()
    {
        string copyright = "©";
        string triangle = @"   {0}
  {0} {0}
 {0} {0} {0}";

        Console.WriteLine(triangle, copyright);
    }
}