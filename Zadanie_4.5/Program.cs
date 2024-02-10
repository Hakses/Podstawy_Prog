// See https://aka.ms/new-console-template for more information
class Program
{
    private static void Main()
    {
        const int rozmiarMacierzy = 10;
        var macierz1 = new int[rozmiarMacierzy, rozmiarMacierzy];
        var macierz2 = new int[rozmiarMacierzy, rozmiarMacierzy];
        var macierz3 = new int[rozmiarMacierzy, rozmiarMacierzy];

        for (var i = 0; i < macierz1.GetLength(0); i++)
        {
            for (var j = 0; j < macierz1.GetLength(1); j++)
            {
                macierz1[i, j] = 1;
                macierz2[i, j] = 2;
            }
        }

        for (var i = 0; i < macierz1.GetLength(0); i++)
        {
            for (var j = 0; j < macierz1.GetLength(1); j++)
            {
                macierz3[i, j] = macierz1[i, j] + macierz2[i, j];
            }
        }

        Console.WriteLine("Macierz wynikowa:");
        for (var i = 0; i < macierz1.GetLength(0); i++)
        {
            for (var j = 0; j < macierz1.GetLength(1); j++)
            {
                Console.Write($"{macierz3[i, j]} ");
            }

            Console.WriteLine();
        }
    }
}