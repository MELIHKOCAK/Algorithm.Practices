using System.Text;

namespace LeetCode.Reverse.Words.@in.a.String;

public class Program
{
    private static bool ContainSpaceCheck(string value)
    {
        var result = value.EndsWith(' ') || value.StartsWith(' ');

        if (result)
            return true;

        return false;
    }

    private static bool LastValueCheck(int index, int length)
    {
        if (index == length -1)
           return true;

        return false;
    }

    private static List<string> ReverseString(string withTrimValue)
    {
        StringBuilder tempStringBuilder = new();
        char space = ' ';
        List<string> StringsWithoutSpace = new();

        for (int i = 0; i < withTrimValue.Length; i++)
        {
            if (withTrimValue[i] == space)
                continue;

            if (i > 0)
            {
                if (withTrimValue[i - 1] == space)//Is Word Finish Check
                {
                    StringsWithoutSpace.Add(tempStringBuilder.ToString());
                    tempStringBuilder.Clear();
                    tempStringBuilder.Append(withTrimValue[i]);
                    if(LastValueCheck(i, withTrimValue.Length))//Last Value Check
                        StringsWithoutSpace.Add(tempStringBuilder.ToString());
                    continue;
                }
            }

            tempStringBuilder.Append(withTrimValue[i]);

            if (LastValueCheck(i, withTrimValue.Length))//Last Value Check
                StringsWithoutSpace.Add(tempStringBuilder.ToString());
        }
        return StringsWithoutSpace;
    }

    public static void Main(string[] args)
    {
        string nonTrimValue = "   Melih Algoritma Öğreniyor  ";
        string withTrimValue = "";

        if (ContainSpaceCheck(nonTrimValue))
            withTrimValue = nonTrimValue.Trim();

        var reversedString = ReverseString(withTrimValue);

        for (int i = reversedString.Count - 1; i >= 0; i--)
            Console.Write(reversedString[i] + " ");
    }

}
