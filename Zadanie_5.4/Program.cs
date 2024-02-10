// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Text;

class Program
{
    private static void Main()
    {
        const string sciezkaPliku = "dane.txt";
        const string tresc = "Sekwencja kwasow nukleinowych: 5-AATTGGCC-3";

        File.WriteAllText(sciezkaPliku, tresc);

        using (var fs = new FileStream(sciezkaPliku, FileMode.Open))
        {
            fs.Seek(32, SeekOrigin.Begin);

            using (var sr = new StreamReader(fs, Encoding.UTF8))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }

        File.Delete(sciezkaPliku);
        Console.Clear();
    }
}