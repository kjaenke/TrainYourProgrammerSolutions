namespace Exercise_32
{
    using System;

    internal static class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("1. Zahl : ");
                var first = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                Console.Write("Operator: ");
                var Operator = Console.ReadLine();
                Console.Write("2. Zahl : ");
                var second = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                switch (Operator)
                {
                    case "+" :
                        Console.WriteLine($"Ergebnis: {first + second}");
                        break;
                    case "-" :
                        Console.WriteLine($"Ergebnis: {first - second}");
                        break;
                    case "/" :
                        Console.WriteLine($"Ergebnis: {first / second}");
                        break;
                    case "*" :
                        Console.WriteLine($"Ergebnis: {first * second}");
                        break;
                }
                Console.WriteLine("Drücken Sie eine beliebige Taste...");
                Console.Read();
            }
        }
    }
}