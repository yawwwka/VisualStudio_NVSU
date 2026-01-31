using System;
using System.Collections;

class Program
{
    static void Main()
    {
        SortedList cities = new SortedList();

        cities.Add("Москва", 12655050);
        cities.Add("Санкт-Петербург", 5384342);
        cities.Add("Новосибирск", 1620162);
        cities.Add("Екатеринбург", 1493749);
        cities.Add("Нижний Новгород", 1252236);
        cities.Add("Казань", 1257391);
        cities.Add("Челябинск", 1202371);

        Console.WriteLine("\n2. Все города:");
        DisplayCities(cities);

        Console.ReadKey();
    }

    static void DisplayCities(SortedList citiesList)
    {
        if (citiesList.Count == 0)
        {
            Console.WriteLine("Нет городов в списке");
            return;
        }

        foreach (DictionaryEntry city in citiesList)
        {
            Console.WriteLine($"Город: {city.Key}, Население: {city.Value}");
        }
    }
}