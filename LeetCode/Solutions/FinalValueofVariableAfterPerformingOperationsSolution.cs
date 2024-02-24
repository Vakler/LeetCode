namespace LeetCode.Utility;

public class FinalValueofVariableAfterPerformingOperationsSolution
{
    public int FinalValueAfterOperations(string[] operations)
    {
        var x = 0;

        foreach (var str in operations)
        {
            switch (str)
            {
                case "--X":
                    x -= 1;
                    break;
                case "X--":
                    x -= 1;
                    break;
                case "X++":
                    x += 1;
                    break;
                case "++X":
                    x += 1;
                    break;
            }
        }
        return x;
    }
}