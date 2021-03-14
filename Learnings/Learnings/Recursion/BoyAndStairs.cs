using System;
using System.Collections.Generic;
using System.Text;

namespace Learnings.Recursion
{
    class BoyAndStairs
    {
        public int NumberOfWays(int n, int[] steps, int start, int end, List<int> paths)
        {
            if (start == end)
            {
                Console.WriteLine(string.Join(",", paths));
                return 1;
            }
            int sum = 0;
            for (int i = 0; i < steps.Length; i++)
            {
                if (n >= steps[i])
                {
                    int nextFloor = start + steps[i];
                    paths.Add(nextFloor);
                    sum += NumberOfWays(n - steps[i], steps, nextFloor, end, paths);
                    paths.RemoveAt(paths.Count - 1);
                }
            }
            return sum;
        }
    }
}
