using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public string FirstName { 
            get { return this.firstName; }
            set 
            {
                if (value.Length < 3) throw new ArgumentException("First name cannot contain fewer 3 symbols! ");
                firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length < 3) throw new ArgumentException("Last name cannot contain fewer than 3 symbols");
                lastName = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0) throw new ArgumentException("Age cannot br zero or a negative integer");
                age = value;
                
            }
        }

        public decimal Salary
        {
            get { return this.salary; }
            set { if (value < 460) {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
            salary = value;
            }
        }

        public Person(string firstName, string lastName, int age, decimal salary )        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }


        public void IncreaseSalary( decimal percentage)
        {
            if(this.Age > 30)
            {
                this.salary += this.salary * percentage / 100;
            }
            else
            {
                this.salary += this.salary * percentage / 200;
            }
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives  {this.Salary} leva.";
        }

    }
}
