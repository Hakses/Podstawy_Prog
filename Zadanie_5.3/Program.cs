// See https://aka.ms/new-console-template for more information
using System.IO;

class Program
{
    private static void Main()
    {
        Console.Write("Podaj tytul ksiazki: ");
        var tytulKsiazki = Console.ReadLine();

        Console.Write("Podaj nazwisko autora: ");
        var nazwiskoAutora = Console.ReadLine();

        const string sciezkaPliku = "biblioteka.txt";

        File.WriteAllText(sciezkaPliku, $"{tytulKsiazki}\n{nazwiskoAutora}");

        var zawartoscPliku = File.ReadAllLines(sciezkaPliku);

        Console.WriteLine($"Tytul ksiazki: {zawartoscPliku[0]}");
        Console.WriteLine($"Nazwisko autora: {zawartoscPliku[1]}");
    }
}
