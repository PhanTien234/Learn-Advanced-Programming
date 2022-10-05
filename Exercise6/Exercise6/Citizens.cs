using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Citizens : IPerson, IBuyer
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;
        private int food;

        public Citizens(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
            this.Food = 0;
        }

        public Citizens(string name, int age, string id)
            : this(name, age, id, "01/01/1970")
        {
        }

        public string Name
        {
            get => this.name;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.Name));
                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Age)} cannot be negative");
                }

                this.age = value;
            }
        }

        public string Id
        {
            get => this.id;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.Id));
                Validator.ValidateOnlyDigits(value, nameof(this.id));
                this.id = value;
            }
        }

        public string Birthdate
        {
            get => this.birthdate;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.Birthdate));
                Validator.ValidateBirthdate(value);
                this.birthdate = value;
            }
        }

        public int Food
        {
            get => this.food;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid food amount");
                }

                this.food = value;
            }
        }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
