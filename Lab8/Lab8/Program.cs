using System;

abstract class BaseClass
{
    public abstract void vvod();
    public abstract void vivod();
}

class DerivedClass1 : BaseClass
{
    private double x, y, z;

    public DerivedClass1()
    {
        x = 0;
        y = 0;
        z = 0;
    }

    public override void vvod()
    {
        Console.Write("x: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.Write("y: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.Write("z: ");
        z = Convert.ToDouble(Console.ReadLine());
    }

    public override void vivod()
    {
        Console.WriteLine($"x={x}, y={y}, z={z}");
    }
}

class DerivedClass2 : BaseClass
{
    private int a, b, c;

    public DerivedClass2()
    {
        a = 0;
        b = 0;
        c = 0;
    }

    public override void vvod()
    {
        Console.Write("a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("c: ");
        c = Convert.ToInt32(Console.ReadLine());
    }

    public override void vivod()
    {
        Console.WriteLine($"a={a}, b={b}, c={c}");
    }
}

class Program1
{
    static void Main()
    {
        DerivedClass1 obj1 = new DerivedClass1();
        DerivedClass2 obj2 = new DerivedClass2();

        obj1.vvod();
        obj1.vivod();

        obj2.vvod();
        obj2.vivod();
    }
}