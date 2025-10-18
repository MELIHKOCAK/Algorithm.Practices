namespace LeetCode.Can.Place.Flowers
{
    internal class Program
    {

        // I solved leetcode 4. algorithm question.
        //https://leetcode.com/problems/can-place-flowers/
        public static bool CanPlaceFlowers(int[] flowers, int valueOfFlowersPlanted)
        {
            int next = 0, previous = 0, counter = 0;

            for (int i = 0; i < flowers.Length; i++)
            {
                if (flowers[i] != 0)
                    continue;

                if ((i + 1) != flowers.Length)
                    next = flowers[i + 1];
                else
                    next = 0;

                if (i - 1 >= 0)
                    previous = flowers[i - 1];

                if (previous == 0 && next == 0)
                {
                    flowers[i] = 1;
                    counter++;
                }
            }

            bool result = counter >= valueOfFlowersPlanted ? true : false;
            return result;
        }

        static void Main(string[] args)
        {
            int[] flowers = { 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0 };
            Console.WriteLine(CanPlaceFlowers(flowers, 3));
        }
    }
}
