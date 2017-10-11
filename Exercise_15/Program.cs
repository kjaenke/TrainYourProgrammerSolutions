namespace Exercise_15
{
    using System;
    using System.Threading;

    public static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Geben Sie die Anzahl der Zeilen für den Weihnachtsbaum ein.");
            var lines = int.Parse(Console.ReadLine()) - 1;

            var counter = 1;

            for (var i = 0; i < lines / 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    BuildRow(counter + j * 2);
                }
                counter += 2;
            }

            WriteCenter("###");
            Thread.Sleep(100000000);
        }

        private static void WriteCenter(string text)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - text.Length / 2, Console.CursorTop);
            Console.WriteLine(text);
        }

        private static void BuildRow(int number)
        {
            var result = string.Empty;

            for (var i = 0; i < number; i++)
            {
                result += '*';
            }

            WriteCenter(result);
        }
    }
}