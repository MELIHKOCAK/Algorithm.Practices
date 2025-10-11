namespace Binary.Search
{
    internal class Program
    {
        // I tried binary seacrh algorithm myself. this solution maybe is not the best solution.
        public static void BinarySearch(int[] array, int findValue)
        {
            int minValue = 0;
            int maxValue = array.Length - 1;
            int midValue = array.Length / 2;

            while (true)
            {
                if (findValue > array[midValue])
                {
                    minValue = midValue;
                    midValue = (minValue + maxValue) / 2 + 1;
                }
                else
                {
                    maxValue = midValue;
                    midValue = (minValue + maxValue) / 2;
                }

                if (findValue == array[midValue])
                {
                    Console.WriteLine($"Cevap Bulundu Dizinin {midValue}. İndeksinde");
                    break;
                }
                else if (midValue + 1 - minValue == 1)
                {
                    Console.WriteLine("Cevap Dizide Yoktur.");
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = { -19, -2, 13, 23, 46, 57, 63, 78, 96, 105, 123, 256, 512, 1024 };
            BinarySearch(array, -19);
        }
    }
}
