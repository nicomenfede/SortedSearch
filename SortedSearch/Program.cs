using System;
using System.Collections.Generic;

public class SortedSearch
{
    public static int CountNumbers(int[] sortedArray, int lessThan)
    {
        int val = Array.BinarySearch(sortedArray, lessThan);

        return val >= 0 
            ? val 
            : ~val;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));
    }
}
