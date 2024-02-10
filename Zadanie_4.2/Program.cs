// See https://aka.ms/new-console-template for more information
class Program
{
    private static void Main()
    {
        var macierz = new int[10, 10];
        var suma = 0;

        for (var i = 0; i < macierz.GetLength(0); i++)
        {
            for (var j = 0; j < macierz.GetLength(1); j++)
            {
                if (i == j)
                {
                    macierz[i, j] = i;
                    suma += i;
                }
                else
                {
                    macierz[i, j] = 0;
                }
            }
        }

        for (var i = 0; i < macierz.GetLength(0); i++)
        {
            for (var j = 0; j < macierz.GetLength(1); j++)
            {
                Console.Write(macierz[i, j] + " ");
            }

            Console.WriteLine();
        }

        Console.WriteLine($"Suma elementow na przekatnej: {suma}");
    }
}
