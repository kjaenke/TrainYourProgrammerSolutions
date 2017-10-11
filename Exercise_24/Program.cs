using System;

namespace Exercise_24
{
    using System.Linq;

    public static class Program
    {
        public static void Main()
        {
            Console.Write("Bitte geben Sie die Untergrenze an:");
            var bottom = int.Parse(Console.ReadLine());
            Console.Write("Bitte geben Sie die Obergenze an:");
            var top = int.Parse(Console.ReadLine());

            int[] numbers = new int[top+1];
            numbers  = numbers.FillArray();

            Run(numbers);
        }

        private static void Run(int[] numbers)
        {
            int countTrys = 0;
            bool win = false;

            do
            {
                countTrys++;
                int number = numbers.Get();
                Console.WriteLine($"{countTrys}. Versuch: {number}");
                string userInput = Console.ReadLine();
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
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            return array;
        }

        public static int Get(this int[] array)
        {
            Random r = new Random();
            while (true)
            {
                int number = r.Next(array.First(),array.Last());
                if (array.Contains(number))
                {
                    return number;
                }
            }
        }

        public static int[] AllSmaller(this int[] array, int number)
        {
            int[] newArray = new int[array.Length];
            int counter = 0;

            foreach (var a in array)
            {
                if (a < number)
                {
                    newArray[counter] = a;
                    counter++;
                }
            }

            return newArray;
        }
        public static int[] AllBigger(this int[] array, int number)
        {
            int[] newArray = new int[array.Length];
            int counter = 0;

            foreach (var a in array)
            {
                if (a > number)
                {
                    newArray[counter] = a;
                    counter++;
                }
            }

            return newArray;
        }
    }
}
