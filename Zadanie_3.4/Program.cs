// See https://aka.ms/new-console-template for more information
class Program
{
    private static void Main()
    {
        string[] zwierzeta = { "kot", "pies", "papuga", "swinka morska" };

        foreach (var zwierze in zwierzeta)
        {
            Console.WriteLine(zwierze);

            if (zwierze != "pies") continue;

            Console.WriteLine("Koniec");
            Console.WriteLine("Czy chcesz zobaczyc pelna liste? (t/n)");
            var odpowiedz = Console.ReadLine()?.ToLower();

            if (odpowiedz == "t")
                continue;
            else if (odpowiedz == "n")
            {
                break;
            }
        }
    }
}
