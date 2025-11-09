namespace LeetCode.Reverse.Vowels.String
{
    internal class Program
    {
        // I solved leetcode fifth algortihm question
        private static bool IsVowels(char value)
        {
            List<char> list = new List<char>()
            {
                'a','e','i','o','u','A','E','I','O','U'
            };

            if (list.Contains(value))
                return true;

            return false;
        }

        public static void Main(string[] args)
        {
            string unturnedValue = "icecream";
            List<char> vowelsLetter = new();
            string turnedValue = "";
            int counter = 0;

            for (int i = unturnedValue.Length - 1; i >= 0; i--)
            {
                if (IsVowels(unturnedValue[i]))
                    vowelsLetter.Add(unturnedValue[i]);
            }

            for (int i = 0; i < unturnedValue.Length; i++)
            {
                if (IsVowels(unturnedValue[i]))
                {
                    turnedValue += vowelsLetter[counter];
                    counter++;
                }
                else
                    turnedValue += unturnedValue[i];
            }
            Console.WriteLine(turnedValue);
        }
    }
}
