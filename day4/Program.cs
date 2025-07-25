using System;
class Lists
{
    static void Main()
    {

        int[] arr = { 5, 7, 9, 3, 1 };
        int n = arr.Length;

        for (int i = 0; i < n / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[n - 1 - i];
            arr[n - 1 - i] = temp;
        }
        Console.WriteLine("Reversed array:", string.Join(",", arr));

    }
    }


