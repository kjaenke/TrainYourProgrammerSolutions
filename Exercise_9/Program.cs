namespace Exercise_9
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;

    public static class Program
    {
        private static void Main(string[] args)
        {
            for (var i = 0; i < 100; i++)
            {
                IList<int> list = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
                list = list.Shuffle();
                Console.Write($"{i}.>");
                Console.Write($"{list[0]} | ");
                Console.Write($"{list[1]} | ");
                Console.Write($"{list[2]} | ");
                Console.Write($"{list[3]} | ");
                Console.Write($"{list[4]} | ");
                Console.Write($"{list[5]} | ");
                Console.Write($"{list[6]} | ");
                Console.Write($"{list[7]} | ");
                Console.Write($"{list[8]} | ");
                Console.WriteLine($"{list[9]}");

                Thread.Sleep(500);
            }
            Console.Read();
        }

        private static IList<T> Shuffle<T>(this IEnumerable<T> list) => list.OrderBy(x => new Random().Next()).ToList();
    }
}