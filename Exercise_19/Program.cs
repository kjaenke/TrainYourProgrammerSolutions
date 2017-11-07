namespace Exercise_19
{
    using System;

    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie den Gesamtbetrag ein:");
            decimal sum = decimal.Parse(Console.ReadLine());
            if (sum >= 10)
            {
                Console.WriteLine($"Discountpreis: {sum -(sum / 100 * 10)}");
                Console.Read();
            }
            else
            {
                Console.WriteLine($"Discountpreis: {sum}");
                Console.Read();
            }
        }
    }
}
