using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1.Models
{
    class Validate
    {
        public string ValidatePassword(string password, string password2)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(password2))
            {
                return "Please enter ot Re-type your Password";
            }
            else
            {
                if (password == password2)
                {
                    return "Passwords Match \n";
                }
                else
                {
                    return "Passwords don't Match \n";
                }
            }
        }

        public string ValidateRequiredField(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "No Input";
            }
            else
            {
                return $"OK!";
            }
        }
    }
}
