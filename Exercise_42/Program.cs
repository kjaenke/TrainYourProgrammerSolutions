namespace Exercise_42
{
    using System;

    public static class Program
    {
        private static void Main()
        {
            for (var i = 99; i > 0; i-- )
            {
                Sing(i);
            }
            Console.Read();
        }

        private static void Sing(int numberOfBeer)
        {
            Console.Write($"{numberOfBeer} bottle");
            if (numberOfBeer != 1)
            {
                Console.Write("s");
            }
            Console.Write($" of beer on the wall, {numberOfBeer} bottle");
            if (numberOfBeer != 1)
            {
                Console.Write("s");
            }
            Console.WriteLine( " of beer.");
            Console.Write($"Take one down and pass it around, {numberOfBeer - 1} bottle");
            if (numberOfBeer != 1)
            {
                Console.Write("s");
            }
            Console.WriteLine(" of beer on the wall.");
            Console.WriteLine();
        }
    }
}



