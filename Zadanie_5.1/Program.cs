// See https://aka.ms/new-console-template for more information
﻿class Program
{
    private static void Main()
    {
        Console.Write("Podaj nazwe miasta: ");
        var city = Console.ReadLine();

        Console.Write("Podaj nazwe wojewodztwa: ");
        var region = Console.ReadLine();

        Console.WriteLine($"Nazwa miasta {city} zawiera {city?.Length} liter. Nazwa wojewodztwa {region} zawiera {region?.Length} liter.");
    }
}
