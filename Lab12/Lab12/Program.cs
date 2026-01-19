using System;
using System.Collections;

class Program
{
    static void Main()
    {
        BitArray b1 = new BitArray(new bool[] { true, false, false, true, true, false, true, true });
        BitArray b2 = new BitArray(new bool[] { true, false, true, false, true, true, false, true });

        BitArray or = new BitArray(b1); or.Or(b2);
        BitArray and = new BitArray(b1); and.And(b2);
        BitArray not = new BitArray(b1); not.Not();

        Console.WriteLine("1: " + Show(b1));
        Console.WriteLine("2: " + Show(b2));
        Console.WriteLine("OR: " + Show(or));
        Console.WriteLine("AND: " + Show(and));
        Console.WriteLine("NOT: " + Show(not));
    }

    static string Show(BitArray b)
    {
        string s = "";
        foreach (bool bit in b) s += bit ? "1" : "0";
        return s;
    }
}