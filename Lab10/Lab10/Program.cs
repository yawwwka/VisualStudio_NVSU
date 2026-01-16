using System;

interface IFirstInterface
{
    void vvod();
    void vivod();
}

interface ISecondInterface : IFirstInterface
{
    void sum();
    void mult();
}

class MyClass : ISecondInterface
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

    public void sum()
    {
        double result = x + y + z;
        Console.WriteLine($"Сумма: {result}");
    }

    public void mult()
    {
        double result = x * y * z;
        Console.WriteLine($"Произведение: {result}");
    }
}

class Program3
{
    static void Main()
    {
        MyClass obj = new MyClass();

        obj.vvod();
        obj.vivod();
        obj.sum();
        obj.mult();
    }
}