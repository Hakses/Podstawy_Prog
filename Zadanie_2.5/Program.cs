// See https://aka.ms/new-console-template for more information
class Program
{
    private static void Main()
    {
        Console.WriteLine("Podaj a:");
        var a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj b:");
        var b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj c:");
        var c = Convert.ToInt32(Console.ReadLine());
        var delta = (b * b) - (4 * a * c);
        var deltaRoot = Math.Sqrt(delta);
        Console.WriteLine("--------------------");
        Console.WriteLine($"Δ = {delta}");

        if (delta > 0)
        {
            Console.WriteLine($"√Δ = {deltaRoot}");
            var x1 = (-b + deltaRoot) / (2 * a);
            var x2 = (-b - deltaRoot) / (2 * a);
            Console.WriteLine($"x1 = {x1:0.0}");
            Console.WriteLine($"x2 = {x2:0.0}");
        }
        else if (deltaRoot == 0)
        {
            var x = -b / (2 * a);
            Console.WriteLine($"x = {x}");
        }
        else
        {
            Console.WriteLine("Brak rozwiazania");
        }
    }
}
