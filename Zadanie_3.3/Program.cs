// See https://aka.ms/new-console-template for more information
class Program
{
    private static void Main()
    {
        var i = 1;
        do
        {
            var kwadrat = i * i;
            Console.WriteLine($"Kwadrat liczby {i} to {kwadrat}");
            i++;
        } while (i <= 20);
    }
}
