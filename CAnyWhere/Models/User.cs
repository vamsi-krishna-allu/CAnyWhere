using Newtonsoft.Json;
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
        [JsonIgnore]
        public string Key { get; set; }

        public User(string EmailId, string Name, string Password, string UserType)
        {
            this.EmailId = EmailId;
            this.Name = Name;
            this.Password = Password;
            this.UserType = UserType;
        }

        public User()
        {
        }
    }
}
