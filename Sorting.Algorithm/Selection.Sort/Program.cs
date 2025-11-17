namespace Selection.Sort
{
    internal class Program
    {
        //I tried myself write selection sort algorithm. This project may has not best solution for Selection Sort Algorithm.
        public static void SelectionSort(int[] arr)
        {
            int temp;
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[j] < arr[i])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 62, -5, 21, 98, 85, 2, 56, 654, 10, -90, -220 };
            SelectionSort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
