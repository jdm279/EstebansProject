using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstebansProject
{
    public static class KnownValues 
    {
        #region INT[]

        public static int[] GetIntArrayThatHasDuplicates()
        {
            return new int[] { 3, 2, 1, 2, 3, 4, 4 };
        }

        public static int[] GetIntArrayThatIsUnique()
        {
            return new int[] { 3, 2, 1 };
        }

        #endregion
        #region LINKED LIST
        public static QuickLinkedListNode<int> GetLinkedListWithCyclicalReferences()
        {
            QuickLinkedListNode<int> firstNode = GetLinkedList();
            QuickLinkedListNode<int> node = firstNode;

            while (node.Next != null)
                node = node.Next;

            node.Next = firstNode;

            return firstNode;
        }
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

