using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vector;

namespace SortPrac
{
    internal class InsertionSort : ISorter
    {
        public void Sort<K>(K[] sequence, IComparer<K> comparer) where K : IComparable<K>
        {
            // check if comparer is null and assign the default comparer
            if (comparer == null) comparer = Comparer<K>.Default;

            // iterate over sequence 
            for (int i = 1; i < sequence.Length; i++)
            {
                var j = i;
                // check if sequence at index j-1 is greater than sequence[j] until j reaches zero
                while ((j > 0) && (comparer.Compare(sequence[j-1], sequence[j]) > 0)) {
                    // assign sequence value of index ref j-1 to temp
                    var temp = sequence[j-1];
                    // assign j-1 the value of sequence[j]
                    sequence[j-1] = sequence[j];
                    // assign temp or j-1 to index of j or really i from the outer for loop.
                    sequence[j] = temp;
                    // decrement 
                    j--;
                }
            }
        }
    }
}
