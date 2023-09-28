using System;
using System.Collections.Generic;


class Programm
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Dictionary<int, string> dictionary = new Dictionary<int, string>()
{
{0,"Zero" },
{1,"One"},
{2,"Two"},
{3,"Three"},
{4,"Four"},
{5,"Five" },
{6,"Six"},
{7,"Seven"},
{8,"Eight"},
{9,"Nine"},
};
        Console.WriteLine(dictionary[n]);
    }
}
