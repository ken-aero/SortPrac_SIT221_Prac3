using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vector;

namespace SortPrac
{
    internal class BubbleSort : ISorter
    {
        public void Sort<K>(K[] sequence, IComparer<K> comparer) where K : IComparable<K>
        {
            // check if comparer is null and assign the default comparer
            if (comparer == null) comparer = Comparer<K>.Default;

            for (int i = 1; i < sequence.Length; i++)
            {
                // track swaps made in each iteration of sequence
                var swaps = 0;
                for (int j = 0; j < sequence.Length - 1; j++)
                {
                    if (comparer.Compare(sequence[j], sequence[j + 1]) > 0)
                    {
                        // assign sequence value of index ref j to temp
                        var temp = sequence[j];
                        // assign j the value of sequence[j + 1]
                        sequence[j] = sequence[j + 1];
                        // assign j+1 to index of temp
                        sequence[j + 1] = temp;
                        // increment swaps
                        swaps++;
                    }
                }
                // no swaps are made break
                if (swaps == 0) break;
            }
        }
    }
}
