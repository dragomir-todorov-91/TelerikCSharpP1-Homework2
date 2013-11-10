//Find online more information about ASCII (American Standard Code for 
//Information Interchange) and write a program that prints the entire 
//ASCII table of characters on the console.

using System;

class ASCIITable
{
    static void Main()
    {
        char helper;
        Console.WriteLine("Dec      Hex     Oct      Char(if visible) ");
        string border = "".PadLeft(45, '-');
        Console.WriteLine(border);
        for (int i = 0; i < 256; i++)
        {
            helper = (char)i;
            Console.Write("{0:D3}      {1:D3}       {2:D3}", i, Convert.ToString(i, 16), Convert.ToString(i, 8));

            if (i != 10 && i != 13)
            {
                Console.WriteLine("         {0} ", helper);
            }
            else
                Console.WriteLine("             " );
        }
        Console.WriteLine(border);
    }
}