namespace Exercise_41
{
    using System;

    internal static class Program
    {
        public static void Main()
        {
        }

        // ReSharper disable once UnusedMember.Local
        private static bool IsLeap(this DateTime date)
        {
            if (date.Year % 4 != 0)
            {
                return false;
            }
            if (date.Year % 100 == 100)
            {
                return date.Year % 400 == 0;
            }
            return true;
        }
    }
}