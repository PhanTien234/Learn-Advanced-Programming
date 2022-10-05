using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class ErrorMessage
    {
        public class ErrorMessages
        {
            public const string InvalidName = "Expected uper case letter! Argument: {0}";
            public const string InvalidNameLength1 = "Expected length at least 4 symbols! Argument: {0}";
            public const string InvalidNameLength2 = "Expected length at least 3 symbols! Argument: {0}";
            public const string InvalidFacultyNumber = "Invalid faculty number!";
            public const string InvalidWeekSalary = "Expected value mismatch! Argument: weekSalary";
            public const string InvalidWorkingHours = "Expected value mismatch! Argument: {0}";
        }
    }
}
