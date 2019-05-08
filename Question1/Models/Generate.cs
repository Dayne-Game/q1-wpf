using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1.Models
{
    class Generate
    {
        public string GenerateUsername(string fname, string lname)
        {
            string fnameToUpper = fname.ToUpper();
            string lnameToUpper = lname.ToUpper();
            return $"Username: {fnameToUpper.Substring(0, 1)}{lnameToUpper} \n";
        }
    }
}
