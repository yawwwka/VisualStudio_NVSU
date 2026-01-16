using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // ArrayList
        ArrayList a1 = new ArrayList();
        Random r = new Random();
        for (int i = 0; i < 6; i++) a1.Add(r.Next(0, 101));
        Console.WriteLine("A1: " + string.Join(" ", a1.ToArray()));

        ArrayList a2 = new ArrayList();
        for (int i = 0; i < 3; i++) a2.Add(a1[i]);
        Console.WriteLine("A2: " + string.Join(" ", a2.ToArray()));

        a2.Sort();
        Console.WriteLine("Sort: " + string.Join(" ", a2.ToArray()));

        a2.Reverse();
        Console.WriteLine("Rev: " + string.Join(" ", a2.ToArray()));

        a2.Insert(1, r.Next(0, 101));
        a2.Insert(3, r.Next(0, 101));
        a2.Insert(5, r.Next(0, 101));
        Console.WriteLine("Ins: " + string.Join(" ", a2.ToArray()));

        Console.WriteLine("Count: " + a2.Count);

        object[] arr = a2.ToArray();
        Console.WriteLine("Array: " + string.Join(" ", arr));
    }
}