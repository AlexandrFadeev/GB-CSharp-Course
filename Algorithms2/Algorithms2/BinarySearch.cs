using System;
using System.Collections.Generic;

namespace Algorithms2
{
    // asymptotic complexity is O(log(n))
    public class BinarySearch
    {
        private enum Compare
        {
            Less = -1,
            Equal,
            Greater
        }
        
        public int? SearchElementFromCollection<T>(List<T> array, T searchItem) where T : IComparable
        {
            if (array.Count == 0)
            {
                return null;
            }
            
            var leftAnchor = 0;
            var rightAnchor = array.Count - 1;

            while (leftAnchor <= rightAnchor)
            {
                var midIndex = Convert.ToInt32((leftAnchor + rightAnchor) * 0.5);
                if (array[midIndex].Equals(searchItem))
                {
                    return midIndex;
                }
                
                if (searchItem.CompareTo(array[midIndex]) == (int)Compare.Less)
                {
                    rightAnchor = midIndex - 1;
                }
                else
                {
                    leftAnchor = midIndex + 1;
                }
            }

            return null;
        }
    }
}