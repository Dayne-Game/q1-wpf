using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1.Models
{
    class UserInfo
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public List<UserInfo> Listedusers { get; set; }

        public UserInfo(string fname, string lname, string email)
        {
            Firstname = fname;
            Lastname = lname;
            Email = email;
        }

        public void AddUserInfoToListedUsers()
        {
            Listedusers.Add(new UserInfo(Firstname, Lastname, Email));
            Listedusers.Add(new UserInfo("Jeff", "Kranenburg", "jeff.kranenburg@acme.com"));
            Listedusers.Add(new UserInfo("Esheel", "Anand", "esh.anand@gmail.com"));
        }

        public string DisplayListedUsers()
        {
            AddUserInfoToListedUsers();
            string output = "";
            foreach (UserInfo userDetails in Listedusers)
            {
                output += $"Firstname: {userDetails.Firstname} | Lastname: {userDetails.Lastname} | Email: {userDetails.Email} \n";
            }

            return output;
        }
    }
}
