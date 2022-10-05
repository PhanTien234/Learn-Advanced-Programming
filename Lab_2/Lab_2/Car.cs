using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Car
    {
        private Tire[] tires;
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public Tire[] Tires
        {
            get => tires;
            set
            {
                if (value.Length == 4)
                {
                    tires = value;
                }
            }
        }

        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }
    }

}
