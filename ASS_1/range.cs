using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_1
{
    internal class range<T> where T:IComparable
    {
        public int MAX { get; set; }
        public int MIN { get; set; }
        public range(int min, int max) 
        {
            MAX = max;
            MIN = min;
        }
        public bool IsInRange(T valu)
        {
            if (valu != null)
            {
                if(valu.CompareTo(MAX)<=1 && valu.CompareTo(MIN)>=0)
                {
                    return true;
                }
            }
            return false;
        }
        public int length(int max ,int min)
        {
            return max- min;
        }
    }
}
