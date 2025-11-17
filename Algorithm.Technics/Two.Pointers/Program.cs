namespace Two.Pointers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //I used "Two Pointers" algorithm technic for find "goal" varaible values.
            int[] arr = { 90, 1233, 2023, 3000, 41235, 46351, 55511, 93354, 1000652 };
            int goal = 57534;
            int first = 0, last = arr.Length - 1;

            while (true)
            {
                if ((arr[first] + arr[last]) == goal)
                    break;
                else if ((arr[first] + arr[last]) < goal)
                    first = first + 1;
                else
                    last = last - 1;
            }

            Console.WriteLine($"Dizinin {first + 1} ve {last + 1} elemanını toplayarak hedefinize ulaşabilirsiniz.");
        }
    }
}
