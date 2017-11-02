namespace Exercise_189
{
    using System;

    internal class Program
    {
        public void BinToDez(string binNo)
        {
            var result = 0;

            for (var i = 0; i < binNo.Length; i++)
            {
                result += int.Parse(binNo[binNo.Length - (i + 1)].ToString()) * (int) Math.Pow(2, i);
            }
            Console.WriteLine($"Binär   : {binNo}");
            Console.WriteLine($"Dezimal : {result}");
        }
    }
}