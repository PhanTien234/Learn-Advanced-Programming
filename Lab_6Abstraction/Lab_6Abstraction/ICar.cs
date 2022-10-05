using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6Abstraction
{
    internal interface ICar
    {
        string Model { get;}
        string Color { get;}
        string Start();
        string Stop();
    }
}
