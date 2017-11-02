namespace Exercise_75
{
    using System;
    using System.IO;
    using Properties;

    internal static class Program
    {
        private static void Main()
        {
            var number = 1;

  
                var sr = new StreamReader(Settings.Default.sms);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine("Zeile {0}: {1} SMS benötigt", number++, CountSms(line));
                }
                sr.Close();

            Console.Read();

        }
        private static int CountSms(string smsText)
        {
            var length = smsText.Length;
            var result = 0;
            if (length > 0)
            {
                result++;
                length -= 160;
            }
            if (length > 0)
            {
                result++;
                length -= 150;
            }
            result += (length + 139) / 140;
            return result;
        }

       
    }
}