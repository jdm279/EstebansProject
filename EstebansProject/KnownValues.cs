using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstebansProject
{
    /// <summary>
    /// Provides known values for testing
    /// </summary>
    public static class KnownValues 
    {
        #region INT[]
        /// <summary>
        /// Creates an array of ints with duplicates
        /// </summary>
        public static int[] GetIntArrayThatHasDuplicates()
        {
            return new int[] { 3, 2, 1, 2, 3, 4, 4 };
        }

        /// <summary>
        /// Creates a unique list of ints
        /// </summary>
        public static int[] GetIntArrayThatIsUnique()
        {
            return new int[] { 3, 2, 1 };
        }

        #endregion
        #region LINKED LIST
        /// <summary>
        /// Creates a three linked list with the last linked to the first
        /// </summary>
        public static QuickLinkedListNode<int> GetLinkedListWithCyclicalReferences()
        {
            QuickLinkedListNode<int> firstNode = GetLinkedList();
            QuickLinkedListNode<int> node = firstNode;

            while (node.Next != null) // Retrieve last node in the list
            {
                node = node.Next;
            }

            node.Next = firstNode; // Create cyclical loop

            return firstNode;
        }
        /// <summary>
        /// Returns three linked list with no cyclical references
        /// </summary>
        public static QuickLinkedListNode<int> GetLinkedList()
        {
            QuickLinkedListNode<int> firstNode = new QuickLinkedListNode<int>();
            firstNode = new QuickLinkedListNode<int>()
            {
                Value = 3,
                Next = new QuickLinkedListNode<int>()
                {
                    Value = 2,
                    Next = new QuickLinkedListNode<int>()
                    {
                        Value = 1,
                    }
                }
            };

            return firstNode;
        }
        #endregion
    }
}

