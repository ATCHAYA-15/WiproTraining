using System;
class Stringoperator
{
    static void Main()
    {
        string firstname = "Harry";
        string lastname = "Potter";
        string fullname = firstname + " " + lastname;
        Console.WriteLine("Fullname: " + fullname);

        Console.WriteLine(firstname == lastname);

        Console.WriteLine(firstname != lastname);

        Console.WriteLine(firstname.CompareTo(lastname));

        Console.WriteLine($"firstname: {firstname}, lastname: {lastname}");

        string str = "Dhoni";
        int length = str.Length;
        Console.WriteLine("Length" + length);

        int charCount = str.Replace(" ", "").Length;
        Console.WriteLine("Character count: " + charCount);

        string str1 = "Atchaya";
        char[] charArray = str1.ToCharArray();
        foreach (char c in charArray)
        {
            Console.WriteLine(c);
        }

        Console.WriteLine(str1.ToUpper());
        Console.WriteLine(str1.ToLower());

        string a = "I am a software developer";
        string b = a.Replace("software", "web");
        Console.WriteLine(b);


    }

}
