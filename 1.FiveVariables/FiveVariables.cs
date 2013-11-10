//Declare five variables choosing for each of them the most appropriate of the 
//types byte, sbyte, short, ushort, int, uint, long, ulong to represent the 
//following values: 52130, -115, 4825932, 97, -10000.

using System;

class FiveVariables
{
    static void Main()
    {
        int number1 = 52130;
        sbyte number2 = -115;
        long number3 = 4825932;
        byte number4 = 97;
        short number5 = -10000;

        Console.WriteLine("1:{0} \n2:{1} \n3:{2} \n4:{3} \n5:{4}", number1, number2, number3, number4, number5);
    }
}
