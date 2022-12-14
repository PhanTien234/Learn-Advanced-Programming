using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Pet :IAnimal
    {
        private string name;
        private string birthdate;

        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
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
    }
}
