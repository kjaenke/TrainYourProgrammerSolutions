namespace Exercise_13
{
    using System;
    using System.Linq;
    using static System.Console;

    public static class Program
    {
        private static int _three;
        private static int _four;
        private static int _five;
        private static int _six;
        private static int _runs;

        public static void Main()
        {
            int[] numbers = new int[6];
            while (true)
            {
                for (var i = 0; i < 6; i++)
                {
                    WriteLine($"Geben Sie die {i + 1}. Zahl ein (1-49):");
                    numbers[i] = int.Parse(ReadLine());
                }

                if (!numbers.Count())
                {
                    WriteLine("Jede Zahl darf nur einmal vorkommen.");
                    continue;
                }

                break;
            }
            Run(numbers);
        }

        private static void Run(int[] numbers)
        {
            _runs = 0;
            while (_six == 0)
            {
                int[] draw;

                do
                {
                    draw = GetDraw();
                } while (!draw.Count());

                WriteLine($"Mein LOS          : {numbers[0]} | {numbers[1]} | {numbers[2]} | {numbers[3]} | {numbers[4]} | {numbers[5]}");
                WriteLine($"Heutige Ziehung   : {draw[0]} | {draw[1]} | {draw[2]} | {draw[3]} | {draw[4]} | {draw[5]}");

                switch (Compare(numbers, draw))
                {
                    case 3:
                        WriteLine("3 Richtige.");
                        _three++;
                        break;
                    case 4:
                        WriteLine("4 Richtige.");
                        _four++;
                        break;
                    case 5:
                        WriteLine("5 Richtige.");
                        _five++;
                        break;
                    case 6:
                        WriteLine("JACKPOTT");
                        _six++;
                        break;
                    default:
                        break;
                }
                _runs++;
            }

            Result();
        }

        private static void Result()
        {
            WriteLine($"Zu{_runs.GetPercent(_three)} Prozent hast du 3 Richtige!");
            WriteLine($"Zu{_runs.GetPercent(_four)} Prozent hast du 4 Richtige!");
            WriteLine($"Zu{_runs.GetPercent(_five)} Prozent hast du 5 Richtige!");
            WriteLine($"Zu{_runs.GetPercent(_six)} Prozent hast du 6 Richtige!");
            WriteLine($"Nach {_runs} Ziehungen");
            Read();
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

        private static double GetPercent(this int runs, int points) => 100 / (double) runs * points;

        private static int[] GetDraw()
        {
            int[] draw = new int[6];
            var r = new Random();
            for (var i = 0; i < 6; i++)
            {
                draw[i] = r.Next(0, 50);
            }
            return draw;
        }

        private static int Compare(int[] numbers, int[] draw)
        {
            var counter = 0;

            foreach (var v in numbers)
            {
                if (draw.Contains(v))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}