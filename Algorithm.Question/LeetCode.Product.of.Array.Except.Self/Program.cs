namespace LeetCode.Product.of.Array.Except.Self
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 7, 9 };
            int[] newArray = new int[array.Length];
            int tempValue = 1;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (j == i)
                        continue;

                    tempValue *= array[j];
                }
                newArray[i] = tempValue;
                tempValue = 1;
            }

            foreach (var item in newArray)
                Console.Write($"{item} ");

        }
    }
}
