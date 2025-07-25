using System;
class ABC
{
    public delegate int Admin(int tutionfess, int transportfees);
    static int Print(int tutionfess, int transportfees)
    {
        Console.WriteLine("Tution fee " + tutionfess);
        Console.WriteLine("Transport fee " + transportfees);
        int total = tutionfess + transportfees;
        Console.WriteLine("Total amount " + total);
        return total;
    }
    static void Main(string[] args)
    {
        Admin calculate = new Admin(Print);
        int tuition = 20000;
        int transport = 3000;

        calculate(tuition, transport);
    }
}



// create a delegate for a admin who is responsible for calculating the
// invoice(int tutionfess , int transportfees) and one more delegate which will
//  print the invoice
