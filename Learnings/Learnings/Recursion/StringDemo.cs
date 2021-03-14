using System;
using System.Collections.Generic;
using System.Text;

namespace Learnings.Recursion
{
    public class StringDemo
    {
        public int AllKLength(string st, string st2, int k, int[] count)
        {
            if (st2.Length == k)
            {
                Console.WriteLine(st2);
                return 1;
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < st.Length; i++)
                {
                    if (count[i] > 0)
                    {
                        st2 += st[i];
                        count[i] = count[i] - 1;
                        sum += AllKLength(st, st2, k, count);
                        st2 = st2.Remove(st2.Length - 1, 1);
                        count[i] = count[i] + 1;
                    }
                }
                return sum;
            }
        }
    }
}
