using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace Lab_4
{
    internal class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;
        

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return weekSalary; }
            set
            {
                if(value < 10)
                {
                    throw new ArgumentException(string.Format(ErrorMessage.ErrorMessages.InvalidWeekSalary, nameof(this.weekSalary)));
                }
                weekSalary = value;
            }
        }
        public decimal WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set
            {
                if(value < 1 || value > 12)
                {
                    throw new ArgumentException(string.Format(ErrorMessage.ErrorMessages.InvalidWorkingHours, nameof(this.workHoursPerDay)));
                }
                workHoursPerDay = value;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Week Salary: {this.WeekSalary}")
                .AppendLine($"Hours per day: {this.WorkHoursPerDay}")
                .AppendLine($"Salary per hour: {GetSalaryPerHour()}");
            return $"{base.ToString()}{sb.ToString().Trim()}{Environment.NewLine}";
        }
        private decimal GetSalaryPerHour()
        {
            return WeekSalary / (5 * WorkHoursPerDay);
        }



    }
}
