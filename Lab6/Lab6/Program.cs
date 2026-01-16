using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Stack stack = new Stack();

        Console.WriteLine("1. Добавление элементов в стек (Push):");
        stack.Push("Первый элемент");
        stack.Push("Второй элемент");
        stack.Push("Третий элемент");

        Console.WriteLine("После операции Push:");
        DisplayStack(stack);

        Console.WriteLine("\n2. Просмотр верхнего элемента (Peek):");
        if (stack.Count > 0)
        {
            Console.WriteLine($"Верхний элемент: {stack.Peek()}");
        }

        Console.WriteLine("\n3. Извлечение верхнего элемента (Pop):");
        if (stack.Count > 0)
        {
            string poppedItem = (string)stack.Pop();
            Console.WriteLine($"Извлеченный элемент: {poppedItem}");
        }

        Console.WriteLine("Стек после Pop:");
        DisplayStack(stack);

        Console.WriteLine($"\n4. Количество элементов в стеке: {stack.Count}");

        Console.WriteLine("\n5. Проверка наличия элементов:");
        Console.WriteLine($"Содержит 'Второй элемент': {stack.Contains("Второй элемент")}");
        Console.WriteLine($"Содержит 'Третий элемент': {stack.Contains("Третий элемент")}");

        Console.WriteLine("\n6. Преобразование стека в массив:");
        object[] array = stack.ToArray();
        Console.WriteLine("Элементы массива:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"  [{i}] = {array[i]}");
        }

        Console.WriteLine("\n7. Очистка стека (Clear):");
        stack.Clear();
        Console.WriteLine($"Количество элементов после очистки: {stack.Count}");

        Console.WriteLine("\n8. Попытка извлечь элемент из пустого стека:");
        try
        {
            stack.Pop();
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("ОШИБКА: Нельзя извлечь элемент из пустого стека!");
        }

        Console.WriteLine("\n9. Добавление новых элементов после очистки:");
        stack.Push("Новый элемент 1");
        stack.Push("Новый элемент 2");

        Console.WriteLine("Содержимое стека:");
        DisplayStack(stack);

        Console.WriteLine("\n10. Итерация по элементам стека:");
        Console.WriteLine("Элементы стека (от верхнего к нижнему):");
        foreach (string item in stack)
        {
            Console.WriteLine($"  {item}");
        }

        Console.ReadKey();
    }

    static void DisplayStack(Stack stack)
    {
        if (stack.Count == 0)
        {
            Console.WriteLine("Стек пуст");
            return;
        }

        Console.WriteLine("Содержимое стека (от верхнего к нижнему):");
        foreach (string item in stack)
        {
            Console.WriteLine($"  {item}");
        }
    }
}