using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_2
{
    internal class Engine1
    {

        private string engineModel;
        private string power;
        private string displacement;
        private string efficiency;

        public string Enginemodel { get { return engineModel; } set { engineModel = value; } }
        public string Power { get { return power; } set { power = value; } }
        public string Displacement { get { return displacement; } set { displacement = value; } }
        public string Efficiency { get { return efficiency; } set { efficiency = value; } }


        public Engine1(string engineModel, string power, string displacement, string efficiency)
        {
            this.engineModel = engineModel;
            this.power = power;
            this.displacement = displacement;
            this.efficiency = efficiency;
        }

       
        public override string ToString()
        {
            return engineModel + " " + power + " " + displacement + " " + efficiency;
        }
    }
}
