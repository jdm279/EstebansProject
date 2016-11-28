using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstebansProject
{
    public static class IdentifyCycles
    {
        /// <summary>
        /// Checks to see if there are circular references in a linked list, starting with the provided linked list node.  
        /// </summary>
        public static bool HasCycles<T>(QuickLinkedListNode<T> node)
        {
            if (!CheckForValues(node, node))
                return false; // Node is null and so there are no circular references.

            return FloydsCycleAlgoritym(node, node.Next.Next);
        }

        /// <summary>
        /// Use the same node as tortoise and hair to start. Uses Floyds Cycle Algorithm explained in
        /// https://en.wikipedia.org/wiki/Cycle_detection#Tortoise_and_hare
        /// </summary>
        /// <returns>True if cycle exists</returns>
        private static bool FloydsCycleAlgoritym<T>(QuickLinkedListNode<T> tortoise, QuickLinkedListNode<T> hair)
        {
            if (!CheckForValues(tortoise, hair))
                return false;

            if (tortoise == hair)
                return true;

            return FloydsCycleAlgoritym(tortoise.Next, hair.Next.Next);
        }

        private static bool CheckForValues<T>(QuickLinkedListNode<T> tortoise, QuickLinkedListNode<T> hair)
        {
            if (tortoise == null || hair == null)
                return false;

            if (hair.Next == null)
                return false;

            return true;
        }
    }
}
