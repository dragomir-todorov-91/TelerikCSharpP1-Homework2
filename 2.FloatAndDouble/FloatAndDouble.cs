//Which of the following values can be assigned to a variable of type 
//float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

using System;

class FloatAndDouble
{
    static void Main()
    {
        double number1 = 34.567839023D;
        float number2 = 12.345F;
        double number3 = 8923.1234857D;
        float number4 = 3456.091F;
        Console.WriteLine("1:{0} \n2:{1} \n3:{2} \n4:{3}", number1, number2, number3, number4);
    }
}