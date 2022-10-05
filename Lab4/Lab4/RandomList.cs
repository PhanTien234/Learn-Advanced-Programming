using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class RandomList : List<string>
    {
        private Random random;
        public RandomList()
        {
            random = new Random();
        }
        public string RemoveRAndomElement()
        {
            int index = random.Next(0, this.Count);
            string str = this[index];
            this.RemoveAt(index);
            return str;
        }
    }
}
