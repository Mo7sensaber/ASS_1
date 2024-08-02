using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_1
{
    public class SortSwap<T> where T : IComparable
    {
        public static void Swap(ref T x, ref T y)
        {
            T temp = x; x = y; y = temp;
        }
        public void Sort(T[] val)
        {
            for (int i = 0; i < val.Length - 1; i++)
            {
                for (int j = 0; j < val.Length - i - 1; j++)
                {
                    if (val[j].CompareTo(val[j + 1]) == 1)
                    {
                        Swap(ref val[j], ref val[j + 1]);
                    }
                }
            }
        }
    }
}
