using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return facultyNumber; }
            set
            {
                if(value.Length < 5 || value.Length >10 || !value.All(char.IsLetterOrDigit))
                {
                    throw new ArgumentException(ErrorMessage.ErrorMessages.InvalidFacultyNumber);
                }
                facultyNumber = value;
            }
           
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Faculty number: {this.FacultyNumber}");
            return $"{base.ToString()}{sb.ToString().Trim()}{Environment.NewLine}";
        }
    }
}
