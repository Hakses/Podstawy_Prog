// See https://aka.ms/new-console-template for more information
using System.Collections;

class Program
{
    private static void Main()
    {
        var miasta = new ArrayList() { "Gdańsk", "Warszawa", "Katowice", "Poznań", "Kraków", "Rzeszów" };
        miasta.Sort();

        foreach (var miasto in miasta)
        {
            Console.WriteLine(miasto);
        }
    }
}
