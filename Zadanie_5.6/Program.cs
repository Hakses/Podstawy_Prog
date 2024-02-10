// See https://aka.ms/new-console-template for more information
﻿class Program
{
    private static int Fibonacci(int n)
    {
        switch (n)
        {
            case 0:
                return 0;
            case 1:
                return 1;
            default:
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

    private static void Main()
    {
        // Console.WriteLine("Podaj numer wyrazu ciagu Fibonacciego:");
        // var i = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine($"{Fibonacci(i - 1)}, {Fibonacci(i)}, {Fibonacci(i + 1)}");

        for (var i = 0; i < 10; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }
    }
}