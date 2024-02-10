// See https://aka.ms/new-console-template for more information
﻿class Program
{
    private static void Main()
    {
        Console.WriteLine("Podaj swoja wage w kilogramach:");
        var waga = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Podaj swoj wzrost w centymetrach:");
        var wzrost = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Twoje BMI wynosi: " + (waga / ((wzrost / 100) * (wzrost / 100))));
    }
}