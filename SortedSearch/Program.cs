using System;
using System.Collections.Generic;

public class SortedSearch
{
    public static int CountNumbers(int[] sortedArray, int lessThan)
    {
        for (int i = 0; i < sortedArray.Length; i++) 
        {
            if (sortedArray[i] >= lessThan)
                return i;
        }
        return 0;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));
    }
}
