using System.Collections.Generic;

namespace PairProgramming
{
    public interface IBagSort
    {
        void AddInt(int n, List<int> l);
        int GetInt(List<int> l);
        void RemoveInt(List<int> l);
        int Count(List<int> l);
        
    }
}