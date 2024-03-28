using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vector;

namespace SortPrac
{
    internal class SelectionSort : ISorter
    {
        public void Sort<K>(K[] sequence, IComparer<K> comparer) where K : IComparable<K>
        {
            // check if comparer is null and assign the default comparer
            if (comparer == null) comparer = Comparer<K>.Default;

            // iterate over sequence K[]
            for (int i = 0; i < sequence.Length; i++)
            {
                // index reference for the current minimum value
                int min = i;
                for (int j = i + 1; j < sequence.Length; j++)
                {
                    // check if sequence at index j is less than current sequence minimum value
                    if (comparer.Compare(sequence[j], sequence[min]) < 0)
                    {
                        // update index reference to new minimum j
                        min = j;
                    }
                }
                if (min != i) // swap min and i when references are different
                {
                    // assign sequence minimum to temp
                    var temp = sequence[min];
                    // update sequence at minimum index to current index value
                    sequence[min] = sequence[i];
                    // update sequence at i index to temp help value
                    sequence[i] = temp;
                }
            }
        }
    }
}
