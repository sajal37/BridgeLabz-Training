// Merge Intervals 

// Given a set of intervals, merge all overlapping intervals. 

// Constraints: n ≤ 1e5; intervals within 32-bit; O(n log n) due to sort. 

// Examples: Input: [[1,3],[2,6],[8,10],[15,18]] → [[1,6],[8,10],[15,18]] 

// Hints: Sort by start, sweep and merge

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[][] arr =
        {
            new[] {1, 3},
            new[] {2, 6},
            new[] {8, 10},
            new[] {15, 18}
        };
        int[][] result = Merge(arr);
        foreach (int[] inter in result)
        {
            Console.WriteLine($"[{inter[0]}, {inter[1]}]");
        }
    }

    public static int[][] Merge(int[][] inter)
    {
        if (inter.Length <= 1)
            return inter;

        Array.Sort(inter, (a, b) => a[0].CompareTo(b[0]));
        var result = new List<int[]>();
        int start = inter[0][0];
        int end = inter[0][1];
        for (int i = 1; i < inter.Length; i++)
        {
            int currStart = inter[i][0];
            int currEnd = inter[i][1];
            if (currStart <= end)
            {
                end = Math.Max(end, currEnd);
            }
            else
            {
                result.Add(new[] { start, end });
                start = currStart;
                end = currEnd;
            }
        }
        result.Add(new[] { start, end });
        return result.ToArray();
    }
}