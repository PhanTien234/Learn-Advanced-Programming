using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Human
    {
        private string fistName;
        private string lastName;
       

        public Human(string firstName, string lastName)
        {
            this.FistName = firstName;
            this.LastName = lastName;
        }

        public string FistName
        {
            get { return fistName; }
            set 
            {
                if (char.IsLower(value[0]))
                {
                    throw new ArgumentException(string.Format(ErrorMessage.ErrorMessages.InvalidName, nameof(this.FistName)));
                }
               else if (value.Length < 4)
                {
                    throw new ArgumentException(string.Format(ErrorMessage.ErrorMessages.InvalidNameLength1, nameof(this.FistName)));
                }
               

                
                    fistName = value; 
            }
        }
        public string LastName
        {
            get { return lastName; }
            set 
            {
                if (char.IsLower(value[0]))
                {
                    throw new ArgumentException(string.Format(ErrorMessage.ErrorMessages.InvalidName, nameof(this.LastName)));
                }
                else if (value.Length < 3)
                {
                    throw new ArgumentException(string.Format(ErrorMessage.ErrorMessages.InvalidNameLength1, nameof(this.LastName)));
                }
                lastName = value; 
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"First Name: {this.FistName}")
                .AppendLine($"Last Name: {this.LastName}");
            return $"{base.ToString()}{Environment.NewLine}{sb.ToString().Trim()}{Environment.NewLine}";
        }

    }
}
