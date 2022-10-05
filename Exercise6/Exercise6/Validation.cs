using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Validation
    {
        public static void ValidateIsNull(string value, string type)
        {
            if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{type} cannot be empty");
            }
        }
    }
}
