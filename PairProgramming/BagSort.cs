using System.Collections.Generic;
using System.Globalization;

namespace PairProgramming
{
    public class BagSort : IBagSort
    {
        public void AddInt(int n, List<int> l)
        {
            l.Add(n);
        }

        public int GetInt(List<int> l)
        {
            int low = 2147483647;
            foreach (var n in l)
            {
                if (n < low)
                {
                    low = n;
                }
            }

            return low;
        }

        public void RemoveInt(List<int> l)
        {
            int low = 2147483647;
            foreach (var n in l)
            {
                if (n < low)
                {
                    low = n;
                }
            }

            l.Remove(low);
        }

        public int Count(List<int> l)
        {
            return l.Count;
        }
    }
}