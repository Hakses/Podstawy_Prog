// See https://aka.ms/new-console-template for more information
﻿class Program
{
    private static void Main()
    {
        Console.Write("Podaj pierwszy lancuch: ");
        var string1 = Console.ReadLine();

        Console.Write("Podaj drugi lancuch: ");
        var string2 = Console.ReadLine();

        Console.WriteLine($"Polaczone lancuchy: {string1 + string2}");
    }
}
