namespace LeetCode.Kids.With.The.Greatest.Number.of.Candies
{
    public class Program
    {

        public static bool[] WhichCandiesIsBig(int[] candies, int extraCandies)
        {
            bool[] whichCandiesIsBig = new bool[candies.Length];
            Array.Sort(candies);
            int biggestCandie = candies[candies.Length - 1];
            for (int i = candies.Length; i >= 0; i--)
            {
                int tempData = 0;
                if ((i - 1) != -1)
                    tempData = candies[i - 1] + extraCandies;
                else if (i - 1 == -1)
                    break;

                if (tempData >= biggestCandie)
                    whichCandiesIsBig[i - 1] = true;
                else
                    whichCandiesIsBig[i - 1] = false;
            }

            return whichCandiesIsBig;
        }

        static void Main(string[] args)
        {
            //I solved leetcode 3. question
            //https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/

            int[] candies = { 5, 8, 2, 4 };
            int extraCandies = 3;

            var result = WhichCandiesIsBig(candies, extraCandies);

            foreach (var item in result)
                Console.WriteLine(item);
        }
    }
}
