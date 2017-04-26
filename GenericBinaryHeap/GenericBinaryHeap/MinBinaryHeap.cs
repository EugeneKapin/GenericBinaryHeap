using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBinaryHeap
{
    class MinBinaryHeap<A> : BinaryHeap<A>
         where A : IComparable
    {
        public MinBinaryHeap(params A[] heap) : base(heap)
        {
        }
        protected override void IncreaseKey(int pos)
        {
            while (pos > 0 && digits[pos].CompareTo(digits[(pos - 1) / 2]) < 0)
            {
                A changed = digits[pos];
                digits[pos] = digits[(pos - 1) / 2];
                digits[(pos - 1) / 2] = changed;
                pos = (pos - 1) / 2;
            }
        }
        public override void Heapify(int pos)
        {
            int left = 2 * pos + 1;
            int right = 2 * pos + 2;
            int biggest = pos;
            if (left < Size && digits[left].CompareTo(digits[biggest]) < 0) biggest = left;
            if (right < Size && digits[right].CompareTo(digits[biggest]) < 0) biggest = right;
            if (biggest != pos)
            {
                A changed = digits[pos];
                digits[pos] = digits[biggest];
                digits[biggest] = changed;
                Heapify(biggest);
            }
        }
    }
}
