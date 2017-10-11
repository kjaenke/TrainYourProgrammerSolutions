namespace Exercise_186
{
    using System;

    public static class Program
    {
        private static void Main()
        {
            var text = Console.ReadLine();
            var invertedText = string.Empty;

            foreach (var c in text)
            {
                invertedText += char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
            }

            Console.WriteLine(invertedText);
            Console.Read();
        }
    }
}