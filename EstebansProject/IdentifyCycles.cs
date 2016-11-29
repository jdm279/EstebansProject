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
            if (!CanContinue(node, node))
            {
                return false; // Node is null and so there are no circular references.
            }

            return FloydsCycleAlgoritym(node, node.Next.Next);
        }

        /// <summary>
        /// Use the same node as tortoise and hair to start. Uses Floyds Cycle Algorithm explained in
        /// https://en.wikipedia.org/wiki/Cycle_detection#Tortoise_and_hare
        /// </summary>
        /// <returns>True if cycle exists</returns>
        private static bool FloydsCycleAlgoritym<T>(QuickLinkedListNode<T> tortoise, QuickLinkedListNode<T> hair)
        {
            if (!CanContinue(tortoise, hair)) // One or Both Racers found the end of the list
            {
                return false;
            }
            if (tortoise == hair) // The two racers caught up to each other, indicating a cyclical loop in the linked list
            {
                return true;
            }

            return FloydsCycleAlgoritym(tortoise.Next, hair.Next.Next); // Continue the race with the hair going twice as fast as the tortoise
        }

        /// <summary>
        /// Checks the links of the nodes to verify that Floyds Cycle Algorithm can continue
        /// </summary>
        private static bool CanContinue<T>(QuickLinkedListNode<T> tortoise, QuickLinkedListNode<T> hair)
        {
            if (tortoise == null || hair == null) // One of the two racers have found the end of the list
                return false;

            if (hair.Next == null) // Hair is twice as fast. Therefor, we need to check the node that he skips to see if it is the end of the list
                return false;

            return true; // Both tortoise and hair can safely continue forward
        }
    }
}
