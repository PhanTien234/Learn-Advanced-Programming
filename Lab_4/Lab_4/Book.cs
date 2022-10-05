using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Book
    {
        private string author;
        private string title;
        private decimal price;


        public string Author
        {
            get { return author; }
            set
            {
                if (char.IsDigit(value[value.IndexOf(" ") + 1]))
                {
                    throw new ArgumentException("Author invalid!");
                }
                    author = value;
            }
        }
        public string Title
        {
            get { return title; }
            set
            {
                if(value.Length <2)
                {
                    throw new ArgumentException("Title must be 2 than character");
                }
                title = value;
            }
        }
        public virtual decimal Price
        {
            get { return price; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Price must more than value 0");
                }
                this.price = value;
            }
        }
        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}").
                AppendLine($"Title: {this.Title}")
                .AppendLine($"Author: {this.Author}")
                .AppendLine($"Price: {this.Price:f2}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
