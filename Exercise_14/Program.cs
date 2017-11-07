namespace Exercise_14
{
    using System;
    using System.Linq;

    static class Program
    {
        static void Main(string[] args)
        {
            int[] array = {28, 97, 35, 0, 8, 68, 68, 87, 9, 46, 86, 327, 5, 293, 845, 723, 94, 85, 73, 94, 8, 27, 529, 59, 03, 84, 75, 90, 2, 3, 8, 4, 98, 75};
            array.MinAndMax();
        }

        static void MinAndMax(this int[] arr)
        {
           Console.WriteLine(arr.OrderByDescending(x => x).First().ToString()); 
           Console.WriteLine(arr.OrderBy(x => x).First().ToString());
            Console.Read();
        }
    }
}
