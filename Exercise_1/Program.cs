namespace Exercise_1
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            GetInteger();
        }

        public static void GetInteger()
        {
            try
            {
                Console.WriteLine("Bitte geben Sie eine ganze Zahl ein.");
                var number = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                Console.WriteLine($"Die eingegebene Zahl lautet: {number}");
                Console.ReadLine();
            }
            catch (Exception)
            {
                GetInteger();
            }
        }
    }
}