using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBinaryHeap
{
    abstract class BinaryHeap<A>
        where A : IComparable
    {
        protected A[] digits;
        public int Size
        {
            get
            {
                return digits.Length;
            }
        }
        public BinaryHeap(params A[] heap)
        {
            digits = new A[0];
            BuildingAHeap(heap);
        }

        protected void BuildingAHeap(params A[] heap)
        {
            Array.Resize(ref digits, heap.Length);
            digits = heap;
            for (int i = (Size - 1) / 2; i >= 0; i--) Heapify(i);
        }
        public abstract void Heapify(int pos);
        protected abstract void IncreaseKey(int pos);

        public void Insert(A key)
        {
            Array.Resize(ref digits, Size + 1);
            digits[Size - 1] = key;
            IncreaseKey(Size - 1);
        }


        public A Extract()
        {
            if (Size >= 1)
            {
                A max = digits[0];
                digits[0] = digits.Last();
                Array.Resize(ref digits, Size - 1);
                Heapify(0);
                return max;
            }
            throw new ArgumentNullException("The heap is empty");
        }

    }
}
