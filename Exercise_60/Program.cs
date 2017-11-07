namespace Exercise_60
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal static class Program
    {
        private static void Main()
        {
            for (var i = 1; i < 100000; i++)
            {
                List<int> t = i.FindeTeiler();
                if (i == t.Sum() - i)
                {
                    Console.Write($"{i} | " + "{");
                    foreach (var teiler in t)
                    {
                        Console.Write($" {teiler} ");
                    }
                    Console.WriteLine("};");
                }
                else
                {
                    Console.WriteLine($"{i} ERFÜLLT DIE BEDINGUNG NICHT");
                }
            }
            Console.Read();
        }

        private static List<int> FindeTeiler(this int n)
        {
            List<int> teiler = new List<int>();
            for (var i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    teiler.Add(i);
                }
            }
            return teiler;
        }
    }
}