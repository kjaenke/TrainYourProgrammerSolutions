namespace Exercise_11
{
    using System;

    public static class Program
    {
        private static void Main()
        {
            try
            {
                Console.WriteLine("Geben Sie eine Zahl ein.");
                var a = int.Parse(Console.ReadLine());

                Console.WriteLine("Geben Sie noch eine Zahl ein.");
                var b = int.Parse(Console.ReadLine());

                var result = 0;

                for (var i = 0; i < b; i++)
                {
                    result += a;
                }

                Console.WriteLine($"{a} * {b} = {result}");
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}