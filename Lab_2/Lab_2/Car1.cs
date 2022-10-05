using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Car1
    {
        private string model;
        private Engine1 engine;
        private string weight;
        private string color;

        public string Model { get { return model; } set { model = value; } }
        public Engine1 Engine { get { return engine; } set { engine = value; } }
        public string Weight { get { return weight; } set { weight = value; } }
        public string Color { get { return color; } set { color = value; } }

        public override string ToString()
        {
            return model + ":" + engine + " " + weight + " " + color + " ";
        }
    }
}
