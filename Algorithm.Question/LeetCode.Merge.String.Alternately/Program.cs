using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Text;

namespace LeetCode.Merge.String.Alternately
{
    internal class Program
    {
        public static string MergeAlternately(string word1, string word2, StringBuilder sb)
        {
            bool whoIsLength = word1.Length >= word2.Length;

            if (whoIsLength == true)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    if (i > word2.Length - 1)
                        sb.Append(word1[i].ToString());
                    else
                        sb.Append(word1[i].ToString() + word2[i].ToString());
                }
            }
            else
            {
                for (int i = 0; i < word2.Length; i++)
                {
                    if (i > word1.Length - 1)
                        sb.Append(word2[i].ToString());
                    else
                       sb.Append(word1[i].ToString() + word2[i].ToString());
                }
            }
            return sb.ToString();
           
        }

        static void Main(string[] args)
        {
            /* 
              Problem: You are given two strings word1 and word2.
                       Merge the strings by adding letters in alternating order, 
                       starting with word1. If a string is longer than the other, 
                       append the additional letters onto the end of the merged string.
                       Return the merged string.
                          Constraints:
                            1 <= word1.length, word2.length <= 100
                            word1 and word2 consist of lowercase English letters.

                            Input: word1 = "abc", word2 = "pqr"
                            Output: "apbqcr"
                            Explanation: The merged string will be merged as so:
                            word1:  a   b   c
                            word2:    p   q   r
                            merged: a p b q c r

            The problem link: https://leetcode.com/problems/merge-strings-alternately/

            */

            //I solved leetcode first algorithm problem. This solution may not be the best solution for this problem.

            string word1 = "abc", word2 = "pqr", result;
            StringBuilder sb = new StringBuilder();
            result = MergeAlternately(word1, word2,sb);
            Console.WriteLine(result);


        }
    }
}
