using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal interface ICar
    {
        public string Model { get; }
        public string Driver { get; }
        string Brakes();
        string GasPedal();
    }
}
