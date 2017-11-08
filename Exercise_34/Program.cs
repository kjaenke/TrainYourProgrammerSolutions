using System;

namespace Exercise_34
{
    static class Program
    {
        static void Main()
        {
            Console.Write("x1: ");
            var x1 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.Write("y1: ");
            var y1 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.Write("x2: ");
            var x2 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.Write("y2: ");
            var y2 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.WriteLine($"Die Entfernung beträgt {Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2))}");
            Console.Read();
        }
    }
}
