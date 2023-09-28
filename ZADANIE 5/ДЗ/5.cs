using System;
using System.Collections.Generic;


class Programm
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Dictionary<int, string> dictionary = new Dictionary<int, string>()
{
{1,"January" },
{2,"February"},
{3,"March"},
{4,"April"},
{5,"May"},
{6,"June" },
{7,"July"},
{8,"August"},
{9,"September"},
{10,"October"},
{11,"November"},
{12,"December"},
};
        Console.WriteLine(dictionary[n]);
    }
}
