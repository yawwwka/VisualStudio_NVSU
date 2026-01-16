using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();

        Console.WriteLine("=== String Queue Operations ===");

        // Enqueue - добавление элементов в очередь
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");

        Console.WriteLine("\nДобавил:");
        DisplayQueue(queue);

        // Peek - просмотр первого элемента без удаления
        Console.WriteLine($"\nПервый элемент: {queue.Peek()}");

        // Dequeue - извлечение и удаление первого элемента
        string dequeued = queue.Dequeue();
        Console.WriteLine($"Удалил: {dequeued}");

        Console.WriteLine("\nПосле удаления:");
        DisplayQueue(queue);

        // Count - количество элементов
        Console.WriteLine($"\nКол-во: {queue.Count}");

        // Contains - проверка наличия элемента
        Console.WriteLine($"Содержит 'Second': {queue.Contains("Second")}");
        Console.WriteLine($"Содержит 'First': {queue.Contains("First")}");

        // Clear - очистка очереди
        queue.Clear();
        Console.WriteLine($"\nКол-во после очистки: {queue.Count}");

        // Enqueue после очистки
        queue.Enqueue("New Element");
        Console.WriteLine("\nОчередь после добавления нового эл-та:");
        DisplayQueue(queue);
    }

    static void DisplayQueue(Queue<string> queue)
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("Очередь пустая");
            return;
        }

        Console.WriteLine("Очередь содержит:");
        foreach (string item in queue)
        {
            Console.WriteLine($"  {item}");
        }
    }
}