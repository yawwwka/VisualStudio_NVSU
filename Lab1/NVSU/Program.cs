using System;

namespace StudentInfo
{
    class Program
    {
        public static string Fio;
        public static int Kurs;
        public static int Group;
        public static void Main(string[] args)
        {
        Console.WriteLine("Введите ФИО студента:");
            Fio = Console.ReadLine();

            Console.WriteLine("Введите курс:");
            Kurs = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите группу:");
            Group = int.Parse(Console.ReadLine());

            Console.WriteLine("=================================");
            Console.WriteLine($"ФИО:     {Fio}");
            Console.WriteLine($"Курс:    {Kurs}");
            Console.WriteLine($"Группа:  {Group}");
            Console.WriteLine("=================================");
            }
    }
}