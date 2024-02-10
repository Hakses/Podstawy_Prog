// See https://aka.ms/new-console-template for more information
class Program
{
    private static void Main()
    {
        const int liczbaPunktow = 10000000;
        double punktyKola = 0, punktyKwadratu = 0;
        const double r = 1.0;
        var rand = new Random();
        var start = Environment.TickCount;

        for (var i = 0; i < liczbaPunktow; i++)
        {
            var x = rand.NextDouble() * 2.0 - 1.0;
            var y = rand.NextDouble() * 2.0 - 1.0;
            
            if (x * x + y * y <= r * r) punktyKola++;
            punktyKwadratu++;
        }

        var pi = 4 * (punktyKola / punktyKwadratu);
        var stop = Environment.TickCount;

        Console.WriteLine($"Szacowane Pi = {pi}");
        Console.WriteLine($"Czas trwania = {stop - start}ms");
    }
}
