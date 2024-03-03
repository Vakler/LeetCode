using System.Runtime.InteropServices.ComTypes;

namespace LeetCode.Algorithms;

public class InsertionSort
{
    public static int[] Sort(int[] source)
    {
        for (var i = 0; i < source.Length; i++)
        {
            var key = source[i]; // Key is the current value of the loop.
            var c = i - 1; // c is what we are comparing against.
            while (c >= 0 && source[c] > key) 
            {
                source[c + 1] = source[c];  // 
                c -= 1; // Moves the comparison down.
            }
            source[c + 1] = key;
        }
        return source;
    }

    public static int[] SortDec(int[] source)
    {
        for (var i = 0; i < source.Length; i++)
        {
            var key = source[i]; // Key is the current value of the loop.
            var c = i - 1; // c is what we are comparing against.
            while (c >= 0 && source[c] < key) 
            {
                source[c + 1] = source[c];  // 
                c -= 1; // Moves the comparison down.
            }
            source[c + 1] = key;
        }
        return source;
    }
    
}