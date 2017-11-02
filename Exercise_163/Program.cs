namespace Exercise_163
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            Hauptmenue();
        }

        private static void Hauptmenue()
        {
            while (true)
            {
                Console.Clear();
                WriteCenter("-----------------------------------------");
                WriteCenter("Hauptmenu");
                Console.Write("1.");
                WriteCenter("Anmelden");
                Console.Write("2.");
                WriteCenter("Konto erstellen");
                WriteCenter("-----------------------------------------");

                switch (Console.ReadLine())
                {
                    case "1": break;
                    case "2": break;
                }
            }
            // ReSharper disable once FunctionNeverReturns
        }

        public void CreateKonto()
        {
            Console.Clear();
            WriteCenter("-----------------------------------------");
            WriteCenter("Konto erstellen");
            WriteCenter("Hier können Sie ein Konto erstellen");
            WriteCenter("Mindestalter für ein Konto beträgt");
            WriteCenter("14 Jahre");
            WriteCenter("");
            WriteCenter("Drücken Sie ENTER!");
            WriteCenter("-----------------------------------------");
            Console.Read();
            Console.Clear();

            Console.Clear();
            Console.Write("Name: ");
        }

        private static void WriteCenter(string text)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - text.Length / 2, Console.CursorTop);
            Console.WriteLine(text);
        }

        
    }

}