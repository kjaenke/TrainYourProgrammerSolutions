namespace Exercise_13
{
    using System;

    public static class Program
    {
        private static int _three = 0;
        private static int Four = 0;
        private static int Five = 0;
        private static readonly int Six = 0;
        public static int Runs { get; } = 0;

        public static void Main()
        {
            int[] numbers = new int[6];
            while (true)
            {
                for (var i = 0; i < 6; i++)
                {
                    Console.WriteLine($"Geben Sie die {i + 1}. Zahl ein (1-49):");
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                if (!numbers.Count())
                {
                    Console.WriteLine("Jede Zahl darf nur einmal vorkommen.");
                    continue;
                }

                break;
            }
            Run();
        }

        private static void Run()
        {
            while (Six == 0)
            {
            }
        }

        private static bool Count(this int[] array)
        {
            foreach (var i in array)
            {
                var counter = 0;
                foreach (var a in array)
                {
                    if (a == i)
                    {
                        counter++;
                    }
                }
                if (counter > 1)
                {
                    return false;
                }
            }
            return true;
        }


        public static int[] GetDraw()
        {
            int[] draw = new int[6];
            var r = new Random();
            for (var i = 0; i < 6; i++)
            {
                draw[i] = r.Next(0, 50);
            }
            return draw;
        }
    }
}