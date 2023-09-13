using N37_HT_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace N37_HT_1.Services
{
    public class UserService
    {
        private readonly List<User> _users;
        public UserService() => _users = new List<User>();
        public User Create(string firstName, string lastName, string status, string emailAddress)
        {
            var newUser = new User(firstName, lastName, status, emailAddress);
            _users.Add(newUser);
            newUser.IsRegistered = true;
            return newUser;
        }
        public User Delete(int id)
        {
            var user = _users.FirstOrDefault(user => user.Id == id);
            if (user is null || user.IsDeleted)
            {
                Console.WriteLine("There is no such user");
                return null;
            }
            user.IsDeleted = true;
            return user;
        }
        public IEnumerable<User> GetUsers()
        {
            foreach (var user in _users)
            {
                yield return user;
            }
        }
    }
}
