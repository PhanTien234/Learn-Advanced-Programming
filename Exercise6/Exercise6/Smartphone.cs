using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Smartphone : ICaller, IBrowser
    {
        public string Browse(string url)
        {
            Validator.ValidateUrl(url);
            return $"Browsing...{url}";
        }
        public string Call(string number)
        {
            Validator.ValidatePhoneNumber(number);
            return $"Calling...{number}";
        }
    }
}
