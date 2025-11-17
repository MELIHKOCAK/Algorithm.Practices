namespace Bubble.Sort
{
    internal class Program
    {
        //I tried myself write bubble sort algorithm. This project may has not best solution for Bubble Sort Algorithm.

        public static void BubbleSort(int[] arr)
        {
            int biggestValue = arr[0];
            int temp;

            for (int j = 0; j < arr.Length; j++)
            {
                for (global::System.Int32 i = 1; i < arr.Length - j; i++)
                {
                    if (biggestValue > arr[i])
                    {
                        temp = biggestValue;
                        arr[i - 1] = arr[i];
                        arr[i] = temp;
                    }
                    else
                    {
                        biggestValue = arr[i];
                    }
                }
                biggestValue = arr[0];
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 13, 998, -5, 885, 14, 84, 63, 21 };
            BubbleSort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
