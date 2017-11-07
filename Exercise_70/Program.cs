namespace Exercise_70
{
    using System;
    using System.Numerics;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            BigInteger n = 30;
            while (true)
            {
                if (n.Test())
                {
                    Console.WriteLine(n);
                    break;
                }
                n += 1;
            }
            Console.Read();
        }

        private static bool Test(this BigInteger n)
        {
            for (var i = 1; i < 31; i++)
            {
                if (n % i != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}