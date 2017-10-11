namespace Exercise_21
{
    using System;

    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("#Startwert:");
            Console.Write("#");
            var start = int.Parse(Console.ReadLine());
            Console.WriteLine("#Endwert:");
            Console.Write("#");
            var ziel = int.Parse(Console.ReadLine());

            for (var i = start; i < ziel + 1; i++)
            {
                Console.WriteLine($"#{i}");
            }
            Console.Read();
        }
    }
}