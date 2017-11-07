namespace Exercise_61
{
    using System;
    using System.Collections.Generic;

    public static class Program
    {
        public static void Main()
        {
            List<int> koeffizientList = new List<int>();
            Console.WriteLine("n: ");
            var n = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            if (n > 2000)
            {
                Console.Clear();
                Console.WriteLine("Der Parameter n muss kleiner gleich 2000 sein.");
                Main();
            }
            var x = n;
            while (x > 1)
            {
                switch (x % 3)
                {
                    case 0:
                        koeffizientList.Add(0);
                        break;
                    case 1:
                        koeffizientList.Add(1);
                        break;
                    case 2:
                        koeffizientList.Add(-1);
                        x++;
                        break;
                    default:
                        break;
                }
                x /= 3;
            }
            koeffizientList.Add(1);

            Console.WriteLine("n = " + n);
            Console.WriteLine("m = " + (koeffizientList.Count - 1));
            Console.WriteLine(n + " =");
            for (var i = koeffizientList.Count - 1; i >= 0; i--)
            {
                switch (koeffizientList[i])
                {
                    case 1:
                        Console.WriteLine("+3**" + i);
                        break;
                    case -1:
                        Console.WriteLine("-3**" + i);
                        break;
                    default:
                        break;
                }
            }
            Console.Read();
        }
    }
}