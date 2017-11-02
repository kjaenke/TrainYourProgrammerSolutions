namespace Exercise_35
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            Console.Write("Geben Sie eine Zahl ein.");
            var value = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine($"Das Ergebnis lautet {CalcFaculty(value)}");
            Console.Read();
        }

        private static int CalcFaculty(int value)
        {
            if (value < 0)
            {
                return 1;
            }
            var result = 1;
            for (var i = 2; i < value + 1; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}