using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N37_HT_1.Models
{
    public class User
    {
        //FirstName, LastName, Status ( Registered, Active, Deleted ) 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Status { get; set; }
        public string EmailAddress { get; set; }
        public bool IsRegistered { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public User(string firstName, string lastName, string status, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            Status = status;
            EmailAddress = emailAddress;
        }
    }
}
