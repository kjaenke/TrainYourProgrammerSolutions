namespace Exercise_37
{
    using System;

    static class Program
    {
        static void Main()
        {
            string inputString = "class Program{{static void Main(){{string inputString ={0}{1}{0};System.Console.Write(inputString ,(char)34,s);}}}}";
            Console.Write(inputString, (char) 34, inputString);
            Console.Read();
        }
    }
}
