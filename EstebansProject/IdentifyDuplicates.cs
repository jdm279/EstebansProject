using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstebansProject
{
    public static class IdentifyDuplicates
    {
        /// <summary>
        /// Checks a collection for duplicate intigers. If the collection is empty or null, the reuslt will be false.
        /// </summary>
        /// <returns>True if collection has duplicates</returns>
        public static bool HasDuplicates (int[] intArray)
        {
            if (intArray == null)
                return false; // if the array is null then there are no duplicates

            HashSet<int> set = new HashSet<int>(intArray); // Unique list of ints from the intArray

            return set.Count() < intArray.Count(); // The set will be less if duplicates exist in the intArray
        }
    }
}
