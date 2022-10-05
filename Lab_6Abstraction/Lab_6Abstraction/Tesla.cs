using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6Abstraction
{
    internal class Tesla : ICar, IElectricCar
    {
        public string Model { get; private set; }
        public string Color { get; private set; }
        public int Batteries { get; private set; }
        public Tesla(string model, string color, int batteries)
        {
            Model = model;
            Color = color;
            Batteries = batteries;
        }
        public string Start()
        {
            return "Engine star\n";
        }
        public string Stop()
        {
            //TODO: ADD Logic here
            return "Breaaak!";
        }
        public override string ToString()
        {
            return $"{Color} Tesla Model {Model} with {Batteries} Batteries\n {Start()}{Stop()}";
        }
    }
}
