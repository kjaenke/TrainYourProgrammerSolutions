namespace Exercise_37
{
    using System;

    internal static class Program
    {
        private static void Main()
        {
            var inputString = "class Program{{static void Main(){{string inputString ={0}{1}{0};System.Console.Write(inputString ,(char)34,s);}}}}";
            Console.Write(inputString, (char) 34, inputString);
            Console.Read();
        }
    }
}