namespace Exercise_72
{
    using System;

    internal static class Program
    {
        private static void Main()
        {
            Console.Write("Zahl eingeben: ");
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Binär:       {Convert.ToByte(number)}");
            Console.WriteLine($"Oktal:       {Convert.ToString(number,8)}");
            Console.WriteLine($"Hexadezimal: {number.ToString("X")}");
            Console.Read();
        }
    }
}