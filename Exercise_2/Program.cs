namespace Exercise_2
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            GetMiddle(new double[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
        }

        public static void GetMiddle(double[] numbers)
        {
            double result = 0;
            foreach (var n in numbers)
            {
                result += n;
            }

            Console.WriteLine($"{result / numbers.Length}");
            Console.Read();
        }
    }
}