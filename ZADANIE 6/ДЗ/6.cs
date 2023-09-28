using System;
using System.Collections.Generic;


class Programm
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Dictionary<int, string> dictionary = new Dictionary<int, string>()
{
{1,"Плохо"},
{2,"Неудовлетворительно"},
{3,"Удовлетворение"},
{4,"Хорошо"},
{5,"Отлично" },
};

        Console.WriteLine("Введите число от 1 до 5:");
        Console.WriteLine(dictionary[n]);
    }
}
