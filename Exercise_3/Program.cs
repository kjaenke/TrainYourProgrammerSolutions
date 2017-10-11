namespace Exercise_3
{
    internal class Program
    {
        private static void Main()
        {
        }

        public static double[] CombineArray(double[] firstArray, double[] secondArray)
        {
            double[] newArray = new double[firstArray.Length + secondArray.Length];
            for (var i = 0; i < firstArray.Length; i++)
            {
                newArray[i] = firstArray[i];
            }
            for (var i = 0; i < secondArray.Length; i++)
            {
                newArray[firstArray.Length + i] = secondArray[i];
            }
            return newArray;
        }
    }
}