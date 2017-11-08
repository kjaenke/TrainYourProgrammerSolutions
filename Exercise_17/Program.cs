namespace Exercise_17
{
    using System;

    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Geben Sie die Cent ein:");
            var cent = Console.ReadLine();
            Console.WriteLine($"Das ergibt {cent.Substring(0, cent.Length - 2)} Dollar und {cent.Substring(cent.Length - 2, 2)} Cent.");
            Console.Read();
        }
    }
}