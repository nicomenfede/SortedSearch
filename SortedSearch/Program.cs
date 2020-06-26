using System;
using System.Collections.Generic;

public class SortedSearch
{
    public static int CountNumbers(int[] sortedArray, int lessThan)
    {
        int count = 0;
        foreach (int i in sortedArray) 
        {
            if (i >= lessThan)
                return count;
            else
                count++;
        }
        return count;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));
    }
}
