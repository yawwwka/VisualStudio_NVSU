using System;

interface IBaseInterface
{
    void vvod();
    void vivod();
}

class RealNumberClass : IBaseInterface
{
    private double x, y, z;

    public void vvod()
    {
        Console.Write("x: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("y: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.Write("z: ");
        z = Convert.ToDouble(Console.ReadLine());
    }

    public void vivod()
    {
        Console.WriteLine($"x={x}, y={y}, z={z}");
    }
}

class IntegerClass : IBaseInterface
{
    private int a, b, c;

    public void vvod()
    {
        Console.Write("a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("c: ");
        c = Convert.ToInt32(Console.ReadLine());
    }

    public void vivod()
    {
        Console.WriteLine($"a={a}, b={b}, c={c}");
    }
}

class Program2
{
    static void Main()
    {
        IBaseInterface obj1 = new RealNumberClass();
        IBaseInterface obj2 = new IntegerClass();

        obj1.vvod();
        obj1.vivod();

        obj2.vvod();
        obj2.vivod();
    }
}