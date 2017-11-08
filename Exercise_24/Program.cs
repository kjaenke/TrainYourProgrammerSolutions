namespace Exercise_24
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Program
    {
        public static void Main()
        {
            Console.Write("Bitte geben Sie die Untergrenze an:");
            var bottom = int.Parse(Console.ReadLine());
            Console.Write("Bitte geben Sie die Obergenze an:");
            var top = int.Parse(Console.ReadLine());

            int[] numbers = new int[top + 1];
            numbers = numbers.FillArray();

            Run(numbers);
        }

        private static void Run(int[] numbers)
        {
            var countTrys = 0;
            var win = false;

            do
            {
                countTrys++;
                var number = numbers.Get();
                Console.WriteLine($"{countTrys}. Versuch: {number}");
                var userInput = Console.ReadLine();
                switch (userInput.ToLower())
                {
                    case "r":
                        Console.WriteLine($"Die gesuchte Zahl war also die {number}!");
                        win = true;
                        break;
                    case "g":
                        numbers = numbers.AllBigger(number);
                        break;
                    case "k":
                        numbers = numbers.AllSmaller(number);
                        break;

                    default:
                        Console.WriteLine("War wohl falsch.");
                        break;
                }
            } while (!win);
            Console.Read();
        }

        private static int[] FillArray(this int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            return array;
        }

        private static int Get(this int[] array)
        {
            var r = new Random();
            while (true)
            {
                var number = r.Next(array.First(), array.Last());
                if (array.Contains(number))
                {
                    return number;
                }
            }
        }

        private static int[] AllSmaller(this IReadOnlyCollection<int> array, int number)
        {
            int[] newArray = new int[array.Count];
            var counter = 0;

            foreach (var a in array)
            {
                if (a >= number)
                {
                    continue;
                }
                newArray[counter] = a;
                counter++;
            }

            return newArray;
        }

        private static int[] AllBigger(this IReadOnlyCollection<int> array, int number)
        {
            int[] newArray = new int[array.Count];
            var counter = 0;

            foreach (var a in array)
            {
                if (a <= number)
                {
                    continue;
                }
                newArray[counter] = a;
                counter++;
            }

            return newArray;
        }
    }
}