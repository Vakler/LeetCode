namespace LeetCode.Utility
{
    public class RomanToIntergerSolution
    {
        public static int RomanToInt(string s)
        {
            var outcome = 0;
            var charArr = s.ToCharArray();
            var romanDict = new Dictionary<string, int>()
            {
                { "I", 1 },
                { "IV", 4 },
                { "V", 5 },
                { "IX", 9 },
                { "X", 10 },
                { "XL", 40 },
                { "L", 50 },
                { "XC", 90 },
                { "C", 100 },
                { "CD", 400 },
                { "D", 500 },
                { "CM", 900 },
                { "M", 1000 },
            };

            for (int i = 0; i < charArr.Length; i++)
            {
                var pValue = charArr[i].ToString();
                var nValue = "";

                if (i + 1 < charArr.Length && pValue != "M")
                {
                    nValue = charArr[i + 1].ToString();
                }

                if (!String.IsNullOrEmpty(nValue) && romanDict.ContainsKey(pValue + nValue))
                {
                    var spValue = pValue += nValue;
                    romanDict.TryGetValue(spValue, out var value);
                    outcome += value;
                    i++;
                }
                else
                {
                    romanDict.TryGetValue(pValue, out var value);
                    outcome += value;
                }
            }
            return outcome;
        }
    }
}