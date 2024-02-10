// See https://aka.ms/new-console-template for more information
class Program
{
    private static void Main()
    {
        Console.WriteLine("Podaj swoj wiek:");
        var wiek = Convert.ToInt32(Console.ReadLine());

        switch (wiek)
        {
            case >= 18:
                Console.WriteLine("Dostep przyznany");
                break;
            case >= 15:
            {
                Console.WriteLine("Czy masz zgodę rodzicow? (t/n)");
                var odpowiedz = Console.ReadLine();

                switch (odpowiedz?.ToLower())
                {
                    case "t":
                        Console.WriteLine("Dostep przyznany");
                        break;
                    case "n":
                        Console.WriteLine("Dostep zabroniony");
                        break;
                    default:
                        Console.WriteLine("Bledna odpowiedz");
                        break;
                }

                break;
            }
            default:
                Console.WriteLine("Dostep zabroniony");
                break;
        }
    }
}
