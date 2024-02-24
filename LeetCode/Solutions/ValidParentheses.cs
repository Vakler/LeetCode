using System.Collections;

namespace LeetCode.Solutions;

public class ValidParentheses
{
    private static readonly Dictionary<string, string> values = new()
    {
        { "{", "}" },
        { "(", ")" },
        { "[", "]" }
    };

    public static bool IsValid(string s)
    {
        var charArr = s.ToCharArray().ToList();
        var stack = new Stack(charArr);
        var isValid = false;
        var lastValue = "";
        var expectedClose = "";
        if (int.IsOddInteger(charArr.Count)) return false;

        for (var i = 0; i < stack.Count; i++)
        {
            var current = stack.Peek().ToString();
            stack.Pop();
            if (values.ContainsKey(current)) values.TryGetValue(current, out expectedClose);
            if (!string.IsNullOrEmpty(lastValue) && lastValue != expectedClose) return false;
        }

        return true;
    }

    private static int FindClosePosition(int openPosition, char expectedValue, List<char> chars)
    {
        var mir = chars.FindLastIndex(x => x == expectedValue);
        return mir;
    }
}