using System;
using System.Collections.Generic;

namespace Find_the_Town_Judge
{
  class Program
  {
    static void Main(string[] args)
    {
      var trust = new int[2][] { new int[] { 1, 3 }, new int[] { 2 ,3 } };
      int n = 3;
      Solution s = new Solution();
      var answer = s.FindJudge(n, trust);
      Console.WriteLine(answer);
    }
  }

  public class Solution
  {
    public int FindJudge(int n, int[][] trust)
    {
      int[] count = new int[n + 1];
      foreach (var t in trust)
      {
        int a = t[0];
        int b = t[1];
        // a knows b
        // outdegree
        count[a]--;
        //indegree
        count[b]++;
      }

      for (int i = 1; i <= n; i++)
      {
        if (count[i] == n - 1) return i;
      }
      return -1;
    }
  }
}
