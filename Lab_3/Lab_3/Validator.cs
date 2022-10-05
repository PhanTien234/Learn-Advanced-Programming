using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Validator
    {
        public static void ThrowIfNumberIsNotInRange(int minValue, int maxValue, int number, string exceptionMessage)
        {
            if (number < minValue || number > maxValue)
            {
                throw new ArgumentException(exceptionMessage);
            }
        }
    }
}
