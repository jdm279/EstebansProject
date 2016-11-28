using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstebansProject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Test Duplicate Integers

            Console.WriteLine("Testing Duplicate Integers");

            SimpleTest("* {0}, Collection Contains Duplicates", true, (Func<bool>)(() => IdentifyDuplicates.HasDuplicates(KnownValues.GetIntArrayThatHasDuplicates())));
            SimpleTest("* {0}, Collection is Unique", false, (Func<bool>)(() => IdentifyDuplicates.HasDuplicates(KnownValues.GetIntArrayThatIsUnique())));
            SimpleTest("* {0}, Collection is Empty", false, (Func<bool>)(() => IdentifyDuplicates.HasDuplicates(new int[] { })));
            SimpleTest("* {0}, Collection is Null", false, (Func<bool>)(() => IdentifyDuplicates.HasDuplicates(null)));

            #endregion
            #region Test Cyclical References

            Console.WriteLine("Testing Cyclical References");

            SimpleTest("* {0}, Collection Contains Cyclical References", true, (Func<bool>)(() => IdentifyCycles.HasCycles(KnownValues.GetLinkedListWithCyclicalReferences())));
            SimpleTest("* {0}, Collection Contains NO Cyclical References", false, (Func<bool>)(() => IdentifyCycles.HasCycles(KnownValues.GetLinkedList())));
            SimpleTest("* {0}, Collection is Empty", false, (Func<bool>)(() => IdentifyCycles.HasCycles(new QuickLinkedListNode<int>())));

            #endregion

            Console.WriteLine("Finished Test. Press Enter to Close.");
            Console.ReadLine();
        }
        /// <summary>
        /// Wraps method in a try catch, printing true, false, or error
        /// </summary>
        /// <param name="messageFormat">Must contain one format argument</param>
        /// <param name="expected"></param>
        /// <param name="method"></param>
        private static void SimpleTest(string messageFormat, bool expected, Func<bool> method)
        {
            try
            {
                Console.WriteLine(messageFormat, method.Invoke() == expected ? "SUCCESS" : "FAIL");
            }
            catch
            {
                Console.WriteLine(messageFormat, "ERROR");
            }
        }
    }
}
