using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Car
    {
        public double FuelAmount { get; set; }

        public double FuelConsumptionFor1km { get; set; }

        public int TraveledKilometers { get; set; }

        public void TryTraveledThisDistance(int currentDistanse)
        {
            double amountOfFuelRequired = FuelConsumptionFor1km * currentDistanse;
            if (FuelAmount > amountOfFuelRequired)
            {
                FuelAmount -= amountOfFuelRequired;
                TraveledKilometers += currentDistanse;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    } 

}
