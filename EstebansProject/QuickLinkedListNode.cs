using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstebansProject
{
    public class QuickLinkedListNode<T> 
    {
        public T Value { get; set; }
        public QuickLinkedListNode<T> Next { get; set; }
    }
}
