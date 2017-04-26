using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBinaryHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            var heap = new MaxBinaryHeap<int>(1, 2, 3, 10, 5, 6, 9, 8, 7);
            var heap1 = new MinBinaryHeap<int>(3, 8, 15, 45, 5, 1, 20, 2, 9);


        }
    }
}
