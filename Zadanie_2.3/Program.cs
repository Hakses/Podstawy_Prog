// See https://aka.ms/new-console-template for more information
﻿class Program
{
    private static void Main()
    {
        const double eur = 1.08, chf = 1.12, gbp = 1.16, usd = 4.30;

        Console.WriteLine("Wpisz ilosc PLN: ");
        var pln = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Wybierz walute: \n1. EUR ({eur})\n2. CHF ({chf})\n3. GBP ({gbp})");
        var wybor = Convert.ToInt32(Console.ReadLine());
        pln /= usd;

        switch (wybor)
        {
            case 1:
                Console.WriteLine($"Dostaniesz {pln * eur} EUR");
                break;
            case 2:
                Console.WriteLine($"Dostaniesz {pln * chf} CHF");
                break;
            case 3:
                Console.WriteLine($"Dostaniesz {pln * gbp} GBP");
                break;
            default:
                Console.WriteLine("Zly wybor");
                break;
        }
    }
}
