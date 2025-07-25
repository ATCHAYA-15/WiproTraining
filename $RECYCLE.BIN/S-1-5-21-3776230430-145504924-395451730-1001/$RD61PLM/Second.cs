using System;

class Second
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("odd");
        }
    }
}