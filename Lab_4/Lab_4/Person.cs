﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual int Age
        {
            get { return this.age; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                age = value;
            }
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));

            return stringBuilder.ToString();
        }
    }
}
