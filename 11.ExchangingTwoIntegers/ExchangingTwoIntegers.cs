//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

class ExchangingTwoIntegers
{
    static void Main()
    {
        int number1, number2;
        number1 = 5;
        number2 = 10;

        Console.WriteLine("Number1:{0}\nNumber2:{1}\n",number1,number2);
        int swapHelper;
        swapHelper = number1;
        number1 = number2;
        number2 = swapHelper;
        Console.WriteLine("Number1:{0}\nNumber2:{1}\n",number1,number2);

    }
}