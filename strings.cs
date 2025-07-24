using System;
class Program
{
    static void Main()
    {

        int a, b;
        Console.WriteLine("Enter a number1 : ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter a number2 : ");
        b = Convert.ToInt32(Console.ReadLine());

        int sum = a + b;
        Console.WriteLine("Sum of two numbers is : ", +sum);

        int multiply = a * b;
        Console.WriteLine("Multiplication of two numbers is : " + multiply);

        int subtract = a - b;
        Console.WriteLine("Subtraction of two numbers is : " + subtract);

        int divide = a / b;
        Console.WriteLine("Division of two numbers is : " + divide);

    }
}