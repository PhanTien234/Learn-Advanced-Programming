using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Ferrari : ICar
    {
        private string model;
        private string driver;
        public Ferrari(string driver)
        {
            this.Model = "488-Spider";
            this.Driver = driver;
        }
        public string Model
        {
            get { return model; }
            private set
            {
                Validation.ValidateIsNull(value, nameof(this.Model));
                this.model = value;
            }
        }
        public string Driver
        {
            get { return driver; }
            set { this.driver = value; }
        }
        public string Brakes()
        {
            return "Brakes!";
        }
        public string GasPedal()
        {
            return "Zadu6avam sA!";
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(this.Model);
            sb.Append("/");
            sb.Append(this.Brakes());
            sb.Append("/");
            sb.Append(this.GasPedal());
            sb.Append("/");
            sb.Append(this.Driver);
            return sb.ToString();
        }
    }
}
