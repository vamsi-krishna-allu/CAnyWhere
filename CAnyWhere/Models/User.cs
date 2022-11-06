using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAnyWhere.Models
{
    internal class User
    {
        public string EmailId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }

        public User(string Id, string Name, string Password, string UserType)
        {
            this.EmailId = Id;
            this.Name = Name;
            this.Password = Password;
            this.UserType = UserType;
        }
    }
}
