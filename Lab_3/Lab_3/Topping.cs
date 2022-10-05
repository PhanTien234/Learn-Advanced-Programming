using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Topping
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 50;

        private string name;
        private int weight;

        public Topping(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                var valueAsLower = value.ToLower();
                if (valueAsLower != "meat" && valueAsLower != "veggies" && valueAsLower != "cheese" && valueAsLower != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.name = value;
            }
        }
        public int Weight
        {
            get => this.weight;
            private set
            {
                Validator.ThrowIfNumberIsNotInRange(MinWeight, MaxWeight, value, $"{this.Name} weight should be in the range[{MinWeight}..{MaxWeight}].");
                this.weight = value;
            }
        }

        public double GetCalories()
        {
            var modifier = GetModifier();
            return this.Weight * 2 * modifier;
        }

        private double GetModifier()
        {
            var modifierLower = this.Name.ToLower();
            if (modifierLower == "meat")
            {
                return 1.2;
            }

            if (modifierLower == "veggies")
            {
                return 0.8;
            }
            if (modifierLower == "cheese")
            {
                return 1.1;
            }
            return 0.9;
        }
    }
}
