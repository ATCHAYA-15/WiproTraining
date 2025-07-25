using System;
class ExceptionExample
{
    static void Main()
    {

        try
        {
            int a = 10;
            int b = 0;
            int result = a / b;
            Console.WriteLine("The result is : " + result);

            int[] arr = { 45, 67, 78 };
            Console.WriteLine("The value is :" + arr[5]);
        }

        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by Zero");
        }

        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Index out of range");

        }

        finally
        {
            Console.WriteLine("You have handled or unhandled exceptions:");
        }
    }
    
    
}
