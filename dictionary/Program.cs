using System;

class Dictionary
{
    static void Main()
    {
        Dictionary<int, string> beginner = new();
        beginner.Add(1, "C#");
        beginner.Add(2, "Angular UI");
        beginner.Add(3, "Joining letter");

        Console.WriteLine(beginner[3]);

        if (beginner.ContainsKey(2))
        {
            Console.WriteLine(beginner[2]);
        }

        // Dictionary<string, List<string>> wishlist = new();
        // wishlist.Add("Adventures", new List<string> { "Hiking", "Rock Climbing" });
        // wishlist.Add("Trip", new List<string> { "Kerala", "Ladakh" });

        // foreach (var item in wishlist)
        // {
        //     Console.WriteLine($"Category: {item:Key}");
        //     Console.WriteLine("Items:");
        // }

        Console.WriteLine("I want to get a joining letter");


    }



}
