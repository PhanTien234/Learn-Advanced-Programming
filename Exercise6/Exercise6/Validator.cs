using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Validator
    {
        public static void ValidateNotNull(string value, string type)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException($"{type} cannot be null");
            }
        }
        public static void ValidatePhoneNumber(string number)
        {
            if (number.Any(x => char.IsLetter(x)) || number.Any(x => char.IsWhiteSpace(x)))
            {
                throw new ArgumentException("Invalid number!");
            }
        }
        public static void ValidateUrl(string url)
        {
            if (url.Any(x => char.IsDigit(x)) || url.Any(x => char.IsWhiteSpace(x)))
            {
                throw new ArgumentException("Invalid URL!");
            }
        }
        public static void ValidateOnlyDigits(string number, string type)
        {
            if (number.Any(x => char.IsLetter(x)) || number.Any(x => char.IsWhiteSpace(x)))
            {
                throw new ArgumentException($"Invalid {type}!");
            }
        }
        public static void ValidateBirthdate(string birthdate)
        {
            var birthdateArgs = birthdate.Split("/");

            if (birthdateArgs.Length != 3)
            {
                throw new ArgumentException("Invalid birthdate format");
            }

            var birthday = int.Parse(birthdateArgs[0]);
            var birthmonth = int.Parse(birthdateArgs[1]);

            if (birthmonth < 1 || birthmonth > 12 || birthday < 1)
            {
                throw new ArgumentException("Invalid birthdate format");
            }

            switch (birthmonth)
            {
                case 2:
                    if (birthday > 29)
                    {
                        throw new ArgumentException("Invalid birthdate format");
                    }

                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (birthday > 30)
                    {
                        throw new ArgumentException("Invalid birthdate format");
                    }

                    break;
                default:
                    if (birthday > 31)
                    {
                        throw new ArgumentException("Invalid birthdate format");
                    }

                    break;
            }
        }
    }
}
