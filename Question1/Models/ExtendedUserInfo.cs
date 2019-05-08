using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1.Models
{
    class ExtendedUserInfo
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string MyRole { get; set; }
        public List<ExtendedUserInfo> ListedExtendedUsers { get; set; }

        public ExtendedUserInfo(string fname, string lname, string email, string myRole)
        {
            Firstname = fname;
            Lastname = lname;
            Email = email;
            MyRole = myRole;

        }

        public void AddUserInfoToListedUsers()
        {
            ListedExtendedUsers.Add(new ExtendedUserInfo(Firstname, Lastname, Email, MyRole));
            ListedExtendedUsers.Add(new ExtendedUserInfo("Jeff", "Kranenburg", "jeff.kranenburg@acme.com", "CEO"));
            ListedExtendedUsers.Add(new ExtendedUserInfo("Esheel", "Anand", "esh.anand@gmail.com", "Manager"));
        }

        public string DisplayListedUsers()
        {
            AddUserInfoToListedUsers();
            string output = "";
            foreach (ExtendedUserInfo userDetails in ListedExtendedUsers)
            {
                output += $"Firstname: {userDetails.Firstname} | Lastname: {userDetails.Lastname} | Email: {userDetails.Email} | MyRole: {userDetails.MyRole} \n";
            }

            return output;
        }
    }
}
