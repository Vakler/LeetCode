namespace LeetCode.Utility;

public class BubbleSort
{
    public static int[] Sort(int[] array)
    {
        var len = array.Length;
        for (var i = 0; i < len - 1; i++)
        {
            for (var j = 0; j < len - i - 1; j++)
            {
                if (array[j] > array[j+1])
                {
                    var temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        return array;
    }
}