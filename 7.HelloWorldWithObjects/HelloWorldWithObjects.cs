﻿//Declare two string variables and assign them with “Hello” and “World”.
//Declare an object variable and assign it with the concatenation of the 
//first two variables (mind adding an interval). Declare a third string 
//variable and initialize it with the value of the object variable 
//(you should perform type casting).

using System;

class HelloWorldWithObjects
{
    static void Main()
    {
        object hello = "Hello";
        object world = "World";
        object helloWorldObj = hello + " " + world + "!";
        string helloWorldStr = (string)helloWorldObj;
        Console.WriteLine(helloWorldStr);
    }
}