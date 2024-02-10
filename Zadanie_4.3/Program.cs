// See https://aka.ms/new-console-template for more information
class Program
{
    private static void Main()
    {
        var tabela = new int[100];
        var sumaParzystych = 0;
        var sumaNieparzystych = 0;

        for (var i = 0; i < tabela.Length; i++)
        {
            tabela[i] = i + 1;
        }

        foreach (var liczba in tabela)
        {
            if (liczba % 2 == 0)
            {
                sumaParzystych += liczba;
            }
            else
            {
                sumaNieparzystych += liczba;
            }
        }

        Console.WriteLine($"Suma liczb parzystych: {sumaParzystych}");
        Console.WriteLine($"Suma liczb nieparzystych: {sumaNieparzystych}");
    }
}
