// See https://aka.ms/new-console-template for more information
class Program
{
    private static void Main()
    {
        var suma = 0;
        var min = int.MaxValue;

        while (true)
        {
            Console.Write("Podaj liczbe (0-10): ");
            var num = Convert.ToInt32(Console.ReadLine());

            if (num is < 0 or > 10)
            {
                continue;
            }

            if (num == 5)
            {
                break;
            }

            if (num < min)
            {
                min = num;
            }

            suma += num * num;
        }

        Console.WriteLine($"Suma kwadratow: {suma}");
        Console.WriteLine($"Minimalna liczba: {min}");
    }
}