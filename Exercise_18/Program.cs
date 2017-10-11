using System;

namespace Exercise_18
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Niederschlag im April :     ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("Niederschlag im Mai   :     ");
            var b = int.Parse(Console.ReadLine());
            Console.Write("Niederschlag im Juni  :     ");
            var c = int.Parse(Console.ReadLine());
            Console.Write($"Durchschnitt:               {(double)(a+b+c) / 3}");
            Console.Read();
        }
    }
}
