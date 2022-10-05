using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal interface IPerson
    {
        public string Name { get; }
        public int Age { get; }
        public string Id { get; }
        public string Birthdate { get; }
    }
}
