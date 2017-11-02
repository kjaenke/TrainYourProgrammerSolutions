namespace Exercise_29
{
    using System;

    internal static class Program
    {
        private static void Main()
        {
            Console.Write("Eingabe Text: ");
            var input = Console.ReadLine();
            Console.Write("Welches Wort soll gesucht werden: ");
            var search = Console.ReadLine();
            Console.WriteLine();
            string[] seperator = {search};
            Console.Write($"Das Wort \"{search}\" wurde {input?.Split(seperator, StringSplitOptions.None).Length - 1} mal gefunden.");
        }
    }
}