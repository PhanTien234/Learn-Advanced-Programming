using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Driver
    {
        private string name;
        public Driver(string name)
        {
            this.Name = name;
        }
        public string Name 
        {
            get { return name; } 
            private set
            {
                Validation.ValidateIsNull(value, nameof(this.Name));
                this.name = value;
            }
        }
    }
}
