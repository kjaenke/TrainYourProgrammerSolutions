namespace Exercise_22
{
    using System;

    internal static class Program
    {
        private static void Main()
        {
            var input = Console.ReadLine();

            for (var i = input.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(input);
            }
            Console.Read();
        }
    }
}