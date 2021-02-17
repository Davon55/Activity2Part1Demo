using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity2Part1.Models
{
    public class UserModel
    {
        // non default constructor
        public  UserModel(string name, string emailAddress, string phoneNumber)
        {
            Name = name;
            EmailAddress = emailAddress;
            Phonenumber = phoneNumber;
        }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Phonenumber { get; set; }
    }
}
