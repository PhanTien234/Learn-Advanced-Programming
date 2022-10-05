using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class StackOfString : Stack<String>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }
        public void AddRange(IEnumerable<string> collection)
        {
            foreach(var element in collection)
            {
                this.Push(element);
            }
        }
    }
}
