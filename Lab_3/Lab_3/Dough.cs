using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Dough
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 200;

        private string flourType;
        private int weight;
        private string bakingTechnique;

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public string FlourType
        {
            get => this.flourType;
            private set
            {
                var valueAsLower = value.ToLower();
                if (valueAsLower != "white" && valueAsLower != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
        }
        public string BakingTechnique
        {
            get => this.bakingTechnique;
            private set
            {
                var valueAsLower = value.ToLower();
                if (valueAsLower != "crispy" && valueAsLower != "chewy" && valueAsLower != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value;
            }
        }
        public int Weight
        {
            get => this.weight;
            private set
            {
                Validator.ThrowIfNumberIsNotInRange(MinWeight, MaxWeight, value, $"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");
                this.weight = value;
            }
        }

        public double GetCalories()
        {
            var flourTypeModifier = GetFlourTypeModifier();
            var bakingModifier = GetBakingModifier();

            return this.Weight * 2 * flourTypeModifier * bakingModifier;
        }

        private double GetBakingModifier()
        {
            var bakingLower = this.BakingTechnique.ToLower();
            if (bakingLower == "crispy")
            {
                return 0.9;
            }

            if (bakingLower == "chewy")
            {
                return 1.1;
            }
            return 1;
        }

        private double GetFlourTypeModifier()
        {
            var flourTypeLower = this.FlourType.ToLower();
            if (flourTypeLower == "white")
            {
                return 1.5;
            }

            return 1;
        }
    }
}
